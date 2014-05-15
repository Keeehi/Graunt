using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graunt
{
    public partial class VarianceWnindow : BaseAnalysisWindow
    {
        private DataTable data;

        public VarianceWnindow(DataTable data)
        {
            InitializeComponent();

            this.data = data;


            this.Text = "Graunt - " + Language.GetString("variance.title");
            fHeader.Text = Language.GetString("variance.header");
            fPossibleColumnsLabel.Text = Language.GetString("variance.possible");
            fSelectedColumnsLabel.Text = Language.GetString("variance.selected");
            fCalculate.Text = Language.GetString("variance.calculate");

            List<string> columnNames = new List<string>();

            foreach (DataColumn dataColumn in data.Columns)
            {
                if (dataColumn.DataType == typeof(int) || dataColumn.DataType == typeof(decimal))
                {
                    columnNames.Add(dataColumn.ColumnName);
                }
            }

            fPossibleColumns.Items.AddRange(columnNames.ToArray());
        }

        private void fMoveRight_Click(object sender, EventArgs e)
        {
            if (fPossibleColumns.SelectedItem != null)
            {
                var y = fPossibleColumns.SelectedItems.Cast<string>().ToArray();
                foreach (string item in y)
                {
                    fSelectedColumns.Items.Add(item);
                    fPossibleColumns.Items.Remove(item);
                }
            }
        }

        private void fMoveLeft_Click(object sender, EventArgs e)
        {
            if (fSelectedColumns.SelectedItem != null)
            {
                var y = fSelectedColumns.SelectedItems.Cast<string>().ToArray();
                foreach (string item in y)
                {
                    fPossibleColumns.Items.Add(item);
                    fSelectedColumns.Items.Remove(item);
                }
            }
        }

        private void fNext_Click(object sender, EventArgs e)
        {
            Data = Language.GetString("variance.method") + "\r\n";

            foreach (string columnName in fSelectedColumns.Items)
            {
                try
                {
                    Data += columnName + ": " + StatisticalFunctions.Variance(data, columnName).ToString() + "\r\n";
                }
                catch {
                    Data += columnName + ": " + Language.GetString("variance.dataTypeExceded")  + "\r\n";
                }
            }

            DialogResult = DialogResult.OK;
        }

    }
}
