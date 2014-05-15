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
    public partial class StandardDeviationWnindow : BaseAnalysisWindow
    {
        private DataTable data;

        public StandardDeviationWnindow(DataTable data)
        {
            InitializeComponent();

            this.data = data;


            this.Text = "Graunt - " + Language.GetString("standardDeviation.title");
            fHeader.Text = Language.GetString("standardDeviation.header");
            fPossibleColumnsLabel.Text = Language.GetString("standardDeviation.possible");
            fSelectedColumnsLabel.Text = Language.GetString("standardDeviation.selected");
            fCalculate.Text = Language.GetString("standardDeviation.calculate");

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
            Data = Language.GetString("standardDeviation.method") + "\r\n";

            foreach (string columnName in fSelectedColumns.Items)
            {
                try
                {
                    Data += columnName + ": " + StatisticalFunctions.StandardDeviation(data, columnName).ToString() + "\r\n";
                }
                catch
                {
                    Data += columnName + ": " + Language.GetString("standardDeviation.dataTypeExceded") + "\r\n";
                }
            }

            DialogResult = DialogResult.OK;
        }

    }
}
