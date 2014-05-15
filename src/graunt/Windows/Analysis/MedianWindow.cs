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
    public partial class MedianWindow : BaseAnalysisWindow
    {
        private DataTable data;

        public MedianWindow(DataTable data)
        {
            InitializeComponent();

            this.data = data;


            this.Text = "Graunt - " + Language.GetString("median.title");
            fHeader.Text = Language.GetString("median.header");
            fPossibleColumnsLabel.Text = Language.GetString("median.possible");
            fSelectedColumnsLabel.Text = Language.GetString("median.selected");
            fCalculate.Text = Language.GetString("median.calculate");

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
            Data = Language.GetString("median.method") + "\r\n";

            foreach (string columnName in fSelectedColumns.Items)
            {
                try
                {
                    Data += columnName + ": " + StatisticalFunctions.Median(data, columnName).ToString() + "\r\n";
                }
                catch
                {
                    Data += columnName + ": " + Language.GetString("median.dataTypeExceded") + "\r\n";
                }
            }

            DialogResult = DialogResult.OK;
        }

        private void GetMedian(DataTable table, string columnName, out int r)
        {
            var orderedPersons = table.AsEnumerable().Select(row => row[columnName]).Where(cell => cell != DBNull.Value).OrderBy(x => x);
            r = (int)orderedPersons.ElementAt((orderedPersons.Count() - 1) / 2);
        }

    }
}
