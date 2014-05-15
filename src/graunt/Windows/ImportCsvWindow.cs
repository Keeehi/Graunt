using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace graunt
{
    public partial class ImportCsvWindow : Form
    {
        public CsvParserResult Data { get; private set; }

        private byte[] fileContent;
        private bool checkColumnsWidth = true;
        private bool justUpdated = false;


        public ImportCsvWindow(string fileName)
        {
            InitializeComponent();

            fileContent = new byte[]{};
            try
            {
                this.fileContent = File.ReadAllBytes(fileName);
            }
            catch { }

            this.Text = "Graunt - " + Language.GetString("import.title");
            fFileFormat.Text = Language.GetString("import.fileFormat");
            fRecordSeparator.Text = Language.GetString("import.recordSeparator");
            fFieldSeparator.Text = Language.GetString("import.fieldSeparator");
            fTextDelimiter.Text = Language.GetString("import.textDelimiter");
            fCommaSeparatedValues.Text = Language.GetString("import.commaSeparatedValues");
            fSemicolonSeparatedValues.Text = Language.GetString("import.semicolonSeparatedValues");
            fTabSeparatedValues.Text = Language.GetString("import.tabSeparatedValues");
            fCustomFormat.Text = Language.GetString("import.customFormat");
            fNewline1.Text = Language.GetString("import.newline");
            fNewline2.Text = Language.GetString("import.newline");
            fNewline3.Text = Language.GetString("import.newline");
            fComma.Text = Language.GetString("import.comma");
            fSemicolon.Text = Language.GetString("import.semicolon");
            fTab.Text = Language.GetString("import.tab");
            fDoubleQuote1.Text = Language.GetString("import.doubleQuote");
            fDoubleQuote2.Text = Language.GetString("import.doubleQuote");
            fNone.Text = Language.GetString("import.none");
            fHasHeader.Text = Language.GetString("import.hasHeader");
            fEncoding.Text = Language.GetString("import.encoding");
            fPartial.Text = Language.GetString("import.partial");
            fNext.Text = Language.GetString("import.next");

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.fCustomRecordSeparator, Language.GetString("import.specialCharactersHint"));
            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip2.SetToolTip(this.fCustomFieldSeparator, Language.GetString("import.specialCharactersHint"));
            System.Windows.Forms.ToolTip ToolTip3 = new System.Windows.Forms.ToolTip();
            ToolTip3.SetToolTip(this.fCustomTextDelimiter, Language.GetString("import.specialCharactersHint"));
            
            this.fEncodingSelect.Items.AddRange(new string[] {
            "UTF-8",
            "Windows-1250",
            "Windows-1252"});
            this.fEncodingSelect.SelectedIndex = 0;
            this.fEncodingSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);

            Data = null;
        }
 
        private void ImportCsvWindow_Load(object sender, EventArgs e)
        {
            this.showPreview();
        }

        private void fNext_Click(object sender, EventArgs e)
        {
            char recordSeparator, fieldSeparator, textDelimiter;

            if (fCommaSeparatedValues.Checked)
            {
                recordSeparator = '\n';
                fieldSeparator = ',';
                textDelimiter = '"';
            }
            else if (fSemicolonSeparatedValues.Checked)
            {
                recordSeparator = '\n';
                fieldSeparator = ';';
                textDelimiter = '"';
            }
            else if (fTabSeparatedValues.Checked)
            {
                recordSeparator = '\n';
                fieldSeparator = '\t';
                textDelimiter = '\0';
            }
            else
            {
                recordSeparator = GetCharacter(fCustomRecordSeparator);
                fieldSeparator = GetCharacter(fCustomFieldSeparator);
                textDelimiter = GetCharacter(fCustomTextDelimiter);
            }

            Encoding encoding;
            switch (fEncodingSelect.SelectedIndex)
            {
                case 1: encoding = Encoding.GetEncoding("windows-1250"); break;
                case 2: encoding = Encoding.GetEncoding("windows-1252"); break;
                default: encoding = Encoding.UTF8; break;
            }

            string inputData = encoding.GetString(fileContent);

            if (recordSeparator == '\n')
            {
                inputData = inputData.Replace("\r\n", "\n");
            }          

            try
            {
                CsvParser csvParser = new CsvParser(inputData, recordSeparator, fieldSeparator, textDelimiter, fHasHeader.Checked);
                Data = csvParser.GetData();
            }
            catch (GeneralException)
            {
                Data = null;
            }

            this.Close();
        }

        private void refreshPreview(object sender, EventArgs e)
        {
            if (((GroupableRadioButton)sender).Checked)
            {
                this.showPreview();
            }
        }

        private static char GetCharacter(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                return '\0';
            }

            switch (textBox.Text)
            {
                case "\\n": return '\n';
                case "\\t": return '\t';
                default: return textBox.Text[0];
            }
        }

        private void showPreview()
        {
            fError.Text = "";
            fError.Visible = false;
            fNext.Enabled = true;
            fPartial.Visible = false;

            char recordSeparator, fieldSeparator, textDelimiter;

            if (fCommaSeparatedValues.Checked)
            {
                recordSeparator = '\n';
                fieldSeparator = ',';
                textDelimiter = '"';
            }
            else if (fSemicolonSeparatedValues.Checked)
            {
                recordSeparator = '\n';
                fieldSeparator = ';';
                textDelimiter = '"';
            }
            else if (fTabSeparatedValues.Checked)
            {
                recordSeparator = '\n';
                fieldSeparator = '\t';
                textDelimiter = '\0';
            }
            else
            {
                recordSeparator = GetCharacter(fCustomRecordSeparator);
                fieldSeparator = GetCharacter(fCustomFieldSeparator);
                textDelimiter = GetCharacter(fCustomTextDelimiter);
            }

            Encoding encoding;
            switch (fEncodingSelect.SelectedIndex)
            {
                case 1: encoding = Encoding.GetEncoding("windows-1250"); break;
                case 2: encoding = Encoding.GetEncoding("windows-1252"); break;
                default: encoding = Encoding.UTF8; break;
            }

            string inputData=encoding.GetString(fileContent);

            if (recordSeparator == '\n')
            {
                inputData = inputData.Replace("\r\n", "\n");
            }

            CsvParserResult csvParserResult;
            this.checkColumnsWidth = false;
            try
            {
                CsvParser csvParser = new CsvParser(inputData, recordSeparator, fieldSeparator, textDelimiter, fHasHeader.Checked);
                csvParserResult = csvParser.GetData(10);
                fDataPreview.DataSource = (DataTable)csvParserResult;

                foreach (DataGridViewColumn column in fDataPreview.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    column.MinimumWidth = 30;
                }

                AutoSizeColums();
            }
            catch (InvalidOperationException)
            {
                csvParserResult = null;
                fDataPreview.DataSource = null;
                fError.Text = Language.GetString("import.manyColumnsError") + ".";
                fError.Visible = true;
                fNext.Enabled = false;
            }
            catch (CsvParserException e)
            {
                csvParserResult = null;
                fDataPreview.DataSource = null;
                fError.Text = Language.GetString("import.parseError")+".\n" + Language.GetString("import.reason") +": "+e.Message + ".";
                fError.Visible = true;
                fNext.Enabled = false;
            }

            if (csvParserResult != null && csvParserResult.IsPartial())
            {
                fPartial.Visible = true;
            }

            this.checkColumnsWidth = true;
            this.fDataPreview_ColumnWidthChanged(null, null);
        }

        private void AutoSizeColums()
        {
            fDataPreview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            for (int i = 0; i < fDataPreview.Columns.Count; i++)
            {
                int width = fDataPreview.Columns[i].Width;
                fDataPreview.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                fDataPreview.Columns[i].Width = width;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.showPreview();
        }

        private void fDataPreview_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            if (this.checkColumnsWidth && fDataPreview.Columns.Count > 0)
            {
                if (!this.justUpdated)
                {
                    int width = fDataPreview.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);

                    if (width < 682)
                    {
                        this.justUpdated = true;
                        fDataPreview.Columns[fDataPreview.Columns.Count - 1].Width += 682 - width;
                    }
                }
                else
                {
                    this.justUpdated = false;
                }
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            if (!fCustomFormat.Checked)
            {
                fCustomFormat.Checked = true;
            }
            else
            {
                showPreview();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showPreview();
        }
    }
}
