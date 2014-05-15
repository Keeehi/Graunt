using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graunt
{
    public partial class DataTypeWindow : Form
    {
        public enum DataType { Numeric, Real, Text };
        public struct DataTypeResult
        {
            public DataType DataType;
            public int Option;
            public string Value;
        }
        public Dictionary<string, DataTypeResult> Result { get; private set; }
        private int badValues = 0;

        public DataTypeWindow(DataTable dataTable)
        {
            InitializeComponent();

            Text = "Graunt - " + Language.GetString("dataType.title");
            fColumn.Text = Language.GetString("dataType.column");
            fType.Text = Language.GetString("dataType.type");
            fBadValue.Text = Language.GetString("dataType.badValue");
            fNext.Text = Language.GetString("dataType.next"); 

            Panel container = (Panel)this.Controls.Find("fRowsWrapper", false)[0];

            Size size;

            if (dataTable == null)
            {
                throw new GeneralException();
            }

            if (dataTable.Columns.Count <= 14)
            {
                size = new Size(968, 36);
            }
            else
            {
                size = new Size(953, 36);
            }

            //creates table lines for user to set parameters of import for each column
            for (int i = 0; i < dataTable.Columns.Count; ++i)
            {
                Panel panel = CreatePanel(dataTable.Columns[i].ColumnName, GuessDataType(dataTable, dataTable.Columns[i]));
                panel.Size = size;
                panel.Location = new Point(1, i*35);
                if (i%2 == 0)
                {
                    panel.BackColor = Color.Silver;
                }
                else
                {
                    panel.BackColor = Color.FromArgb(224, 224, 224);
                }

                container.Controls.Add(panel);

            }
        }

        private static DataType GuessDataType(DataTable table, DataColumn column)
        {
            int[] conversion = new int[]{0,0,0};

            int cnt = 0;

            foreach (DataRow row in table.Rows)
            {
                string cell = row.Field<string>(column);

                if (cell == null)
                {
                    continue;
                }


                if (!string.IsNullOrEmpty(cell))
                {
                    try
                    {
                        Convert.ToDecimal(cell);
                        ++conversion[1];
                        continue;
                    }
                    catch { }
                    try
                    {
                        Convert.ToInt32(cell);
                        ++conversion[0];
                        continue;
                    }
                    catch { }

                    ++conversion[2];
                }       

                if (cnt++ >= 100) { break; } // try only first aprox. 100 records        
            }

            int maximum = conversion.Max();

            if (maximum == 0)
            {
                return DataType.Text;
            }
            if (maximum == conversion[1])
            {
                return DataType.Real;
            }
            if (maximum == conversion[0])
            {
                return DataType.Numeric;
            }

            return DataType.Text;
        }
        
        private Panel CreatePanel(string columnName, DataType dataType) {

            Panel row = new Panel();
            row.SuspendLayout();

            Label name = new Label();
            name.AutoEllipsis = true;
            name.Location = new Point(11, 9);
            name.Name = "row-" + columnName + ".name";
            name.Size = new Size(122, 17);
            name.Text = columnName;

            ComboBox type = new ComboBox();
            type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            type.Items.AddRange(new object[] { Language.GetString("dataType.numeric"), Language.GetString("dataType.real"), Language.GetString("dataType.text") });
            switch (dataType)
            {
                case DataType.Numeric: type.SelectedIndex = 0; break;
                case DataType.Real: type.SelectedIndex = 1; break;
                case DataType.Text: type.SelectedIndex = 2; break;
            }
            type.Location = new Point(154, 6);
            type.Name = "row-" + columnName + ".type";
            type.Size = new Size(76, 21);
            type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);

            row.Controls.Add(name);
            row.Controls.Add(type);

            foreach (Control control in CreateSettings("row-" + columnName, dataType))
            {
                row.Controls.Add(control);
            }

            row.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            row.Name = "row-" + columnName;

            row.ResumeLayout(false);
            row.PerformLayout();

            return row;
        }

        //creates GUI settings
        private List<Control> CreateSettings(string namePrefix, DataType dataType)
        {
            List<Control> r = new List<Control>();

            RadioButton useEmpty = new RadioButton();
            useEmpty.AutoSize = true;
            useEmpty.Location = new Point(271, 7);
            useEmpty.Name = namePrefix + ".useEmpty";
            useEmpty.Text = Language.GetString("dataType.empty");
            useEmpty.Checked = true;
            r.Add(useEmpty);
            
            RadioButton useMedian = new RadioButton();
            useMedian.AutoSize = true;
            useMedian.Location = new Point(435, 7);
            useMedian.Name = namePrefix + ".useMedian";
            useMedian.Text = Language.GetString("dataType.median");
            r.Add(useMedian);

            RadioButton useMean = new RadioButton();
            useMean.AutoSize = true;
            useMean.Location = new Point(545, 7);
            useMean.Name = namePrefix + ".useMean";
            useMean.Text = Language.GetString("dataType.mean");
            r.Add(useMean);

            RadioButton skip = new RadioButton();
            skip.AutoSize = true;
            skip.Location = new Point(652, 7);
            skip.Name = namePrefix + ".skip";
            skip.Text = Language.GetString("dataType.skip");
            r.Add(skip);  

            RadioButton useCustom = new RadioButton();
            useCustom.AutoSize = true;
            useCustom.Location = new Point(800, 7);
            useCustom.Name = namePrefix + ".useCustom";
            useCustom.Text = Language.GetString("dataType.custom");
            r.Add(useCustom);


            TextBox custom = new TextBox();
            custom.Location = new Point(858, 6);
            custom.Name = namePrefix + ".custom";
            custom.Size = new Size(77, 20);
            custom.TabStop = false;
            custom.Enabled = false;
            r.Add(custom);

            if (dataType == DataType.Text)
            {
                useMedian.Enabled = false;
                useMean.Enabled = false;
            }
          
            custom.Validating += new System.ComponentModel.CancelEventHandler(this.custom_Validating);
            useCustom.CheckedChanged += new System.EventHandler(this.useCustom_CheckedChanged);

            return r;
        }

        //logic of enabling and disabling some of the settings according to selected type
        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            Panel parent = (Panel)comboBox.Parent;

            RadioButton useEmpty = (RadioButton)parent.Controls.Find(parent.Name + ".useEmpty", false)[0];
            RadioButton useMedian = (RadioButton)parent.Controls.Find(parent.Name + ".useMedian", false)[0];
            RadioButton useMean = (RadioButton)parent.Controls.Find(parent.Name + ".useMean", false)[0];
            RadioButton skip = (RadioButton)parent.Controls.Find(parent.Name + ".skip", false)[0];
            RadioButton useCustom = (RadioButton)parent.Controls.Find(parent.Name + ".useCustom", false)[0];
            TextBox custom = ((TextBox)parent.Controls.Find(parent.Name + ".custom", false)[0]);
            
            if (comboBox.SelectedIndex == 2)
            {
                useMedian.Enabled = false;
                useMean.Enabled = false;
                if (useMedian.Checked || useMean.Checked)
                {
                    useEmpty.Checked = true;
                }
            }
            else
            {
                useMedian.Enabled = true;
                useMean.Enabled = true;
            }

            if (useCustom.Checked && !IsValid(custom))
            {
                custom.Focus();
                custom.Select(0, custom.Text.Length);
            }

            if (custom.BackColor == Color.FromArgb(255, 192, 192))
            {
                --badValues;
            }
            custom.BackColor = SystemColors.Window;

            if (badValues == 0)
            {
                fNext.Enabled = true;
            }
            else
            {
                fNext.Enabled = false;
            }
        }

        private void custom_Validating(object sender, CancelEventArgs e)
        {
            TextBox custom = (TextBox)sender;
            if (!IsValid(custom))
            {
                if (custom.BackColor == SystemColors.Window)
                {
                    ++badValues;
                }
                custom.BackColor = Color.FromArgb(255, 192, 192);
            }
            else
            {
                if (custom.BackColor == Color.FromArgb(255, 192, 192))
                {
                    --badValues;
                }
                custom.BackColor = SystemColors.Window;
            }

            if (badValues == 0)
            {
                fNext.Enabled = true;
            }
            else
            {
                fNext.Enabled = false;
            }

        }

        private static bool IsValid(TextBox textBox)
        {
            ComboBox type = (ComboBox)textBox.Parent.Controls.Find(textBox.Parent.Name + ".type", false)[0];

            switch (type.SelectedIndex)
            {
                case 0: try
                    {
                        Convert.ToInt32(textBox.Text);
                        return true;
                    }
                    catch { return false; }

                case 1: try
                    {
                        Convert.ToDecimal(textBox.Text);
                        return true;
                    }
                    catch { return false; }
                default: return true;
            }
        }

        //gathers all settings together, makes them visible from outside
        private void fNext_Click(object sender, EventArgs e)
        {
            Dictionary<string, DataTypeResult> r = new Dictionary<string, DataTypeResult>();

            Panel container = (Panel)this.Controls.Find("fRowsWrapper", false)[0];

            foreach (Panel panel in container.Controls.OfType<Panel>())
            {
                if (panel.Name == "fNextWrapper") { continue; }

                DataTypeResult row = new DataTypeResult();
                
                ComboBox type = (ComboBox)panel.Controls.Find(panel.Name + ".type", false)[0];
                
                switch (type.SelectedIndex) {
                    case 0: row.DataType = DataType.Numeric; break;
                    case 1: row.DataType = DataType.Real; break;
                    default: row.DataType = DataType.Text; break;
                }

                if (((RadioButton)panel.Controls.Find(panel.Name + ".useEmpty", false)[0]).Checked)
                {
                    row.Option = 0;
                }
                else if (((RadioButton)panel.Controls.Find(panel.Name + ".useMedian", false)[0]).Checked)
                {
                    row.Option = 1;
                } 
                else if (((RadioButton)panel.Controls.Find(panel.Name + ".useMean", false)[0]).Checked)
                {
                    row.Option = 2;
                } 
                else if (((RadioButton)panel.Controls.Find(panel.Name + ".skip", false)[0]).Checked)
                {
                    row.Option = 3;
                }
                else
                {
                    row.Option = 4;
                    row.Value = ((TextBox)panel.Controls.Find(panel.Name + ".custom", false)[0]).Text;
                }


                r.Add(panel.Name.Substring(4), row);
            }

            Result = r;

            Close();
        }

        //logic of enabling and disabling some of the settings according to selected type
        private void useCustom_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton useCustom = (RadioButton)sender;
            TextBox custom = (TextBox)useCustom.Parent.Controls.Find(useCustom.Parent.Name + ".custom", false)[0];

            if (useCustom.Checked)
            {
                custom.Enabled = true;
                if (!IsValid(custom))
                {
                    custom.Focus();
                    custom.Select(0, custom.Text.Length);
                }
            }
            else
            {
                custom.Enabled = false;
            }

            if (custom.BackColor == Color.FromArgb(255, 192, 192))
            {
                --badValues;
            }
            custom.BackColor = SystemColors.Window;
            
            if (badValues == 0)
            {
                fNext.Enabled = true;
            }
            else
            {
                fNext.Enabled = false;
            }
        }
    }
}
