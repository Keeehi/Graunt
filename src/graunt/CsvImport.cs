using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graunt
{
    //This class controls the procces of importing data 
    class CsvImport
    {
        //for storing partial results between 
        private CsvParserResult result;
        public DataTable Data { get; private set; }
        public string FileName { get; private set; }

        public event FinishedEventHandler Finished;

        protected virtual void OnFinished(EventArgs e)
        {
            if (Finished != null)
                Finished(this, e);
        }

        public void Import()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.Title = Language.GetString("import.openDialogTitle");

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                ImportCsvWindow importWindow = new ImportCsvWindow(openFileDialog.FileName);
                importWindow.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImportCsvWindow_FormClosing);
                importWindow.Show();
            }
            else
            {
                Data = null;
                OnFinished(EventArgs.Empty);
            }
        }
        private void ImportCsvWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            ImportCsvWindow importWindow = (ImportCsvWindow)sender;
            result = importWindow.Data;
            Data = (DataTable)result;

            if (result != null)
            {
                if (result.IsPartial())
                {
                    throw new GeneralException();
                }

                if (!result.IsValid())
                {
                    RectangularCorrectionWindow rectangularCorrectionWindow = new RectangularCorrectionWindow(result.columnNames, result.GetMostFrequentRecordLength()-1);
                    rectangularCorrectionWindow.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RectangularCorrectionWindow_FormClosing);
                    rectangularCorrectionWindow.Show();
                }
                else
                {
                    ColumnsSelectWindow columnsSelectWindow = new ColumnsSelectWindow(Data.Columns.Cast<DataColumn>().Select(y => y.ColumnName).ToArray());
                    columnsSelectWindow.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColumnsSelectWindow_FormClosing);
                    columnsSelectWindow.Show();
                }
            }
        }

        private void RectangularCorrectionWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            RectangularCorrectionWindow rectangularCorrectionWindow = (RectangularCorrectionWindow)sender;

            int i;
            for (i = result.columns - 1; i > rectangularCorrectionWindow.SelectedColumn; --i)
            {
                Data.Columns.RemoveAt(i);
            }

            if (rectangularCorrectionWindow.ShorterRecords == 1 || rectangularCorrectionWindow.LongerRecords == 1)
            {
                for (i = Data.Rows.Count - 1; i >= 0; --i)
                {
                    int length = result.recordsLength[i];
                    if (rectangularCorrectionWindow.LongerRecords == 1 && length > rectangularCorrectionWindow.SelectedColumn + 1)
                    {
                        Data.Rows[i].Delete();
                    }
                    else if (rectangularCorrectionWindow.ShorterRecords == 1 && length < rectangularCorrectionWindow.SelectedColumn + 1)
                    {
                        Data.Rows[i].Delete();
                    }
                }
            }

            ColumnsSelectWindow columnsSelectWindow = new ColumnsSelectWindow(Data.Columns.Cast<DataColumn>().Select(y => y.ColumnName).ToArray());
            columnsSelectWindow.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColumnsSelectWindow_FormClosing);
            columnsSelectWindow.Show();
        }

        private void ColumnsSelectWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            ColumnsSelectWindow columnsSelectWindow = (ColumnsSelectWindow)sender;

            foreach (string columnName in columnsSelectWindow.SelectedColumns)
            {
                Data.Columns.Remove(columnName);
            }

            DataTypeWindow dataTypeWindow = new DataTypeWindow(Data);
            dataTypeWindow.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataTypeWindow_FormClosing);
            dataTypeWindow.Show();
        }

        private void DataTypeWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataTypeWindow dataTypeWindow = (DataTypeWindow)sender;
            DataTable table = new DataTable();
            table.Locale = Thread.CurrentThread.CurrentCulture;


            Dictionary<string, DataTypeWindow.DataType> skip = new Dictionary<string, DataTypeWindow.DataType>();
            Dictionary<string, DataTypeWindow.DataTypeResult> other = new Dictionary<string, DataTypeWindow.DataTypeResult>();
            Dictionary<string, List<int>> bad = new Dictionary<string, List<int>>();

            //sorting cloumns acording to priority, "discard record" column first, other laer
            foreach (KeyValuePair<string, DataTypeWindow.DataTypeResult> row in dataTypeWindow.Result)
            {
                Type type;

                switch (row.Value.DataType)
                {
                    case DataTypeWindow.DataType.Numeric: type = typeof(int); break;
                    case DataTypeWindow.DataType.Real: type = typeof(decimal); break;
                    default: type = typeof(string); break;
                }


                table.Columns.Add(row.Key, type);

                if (row.Value.Option == 3)
                {
                    skip.Add(row.Key, row.Value.DataType);
                }
                else
                {
                    other.Add(row.Key, row.Value);
                }
            }

            //itereation through whole set, line by line
            int rowNum = 0;
            foreach (DataRow row in Data.Rows)
            {
                DataRow newRow = table.NewRow();

                //testing "discard record" columns
                bool broken = false;
                foreach (KeyValuePair<string, DataTypeWindow.DataType> pair in skip)
                {
                    if (row[pair.Key] == DBNull.Value)
                    {
                        broken = true;
                        break;
                    }

                    try
                    {
                        switch (pair.Value)
                        {
                            case DataTypeWindow.DataType.Numeric: newRow[pair.Key] = Convert.ToInt32(row[pair.Key]);   break;
                            case DataTypeWindow.DataType.Real:    newRow[pair.Key] = Convert.ToDecimal(row[pair.Key]); break;
                            default:                              newRow[pair.Key] = row[pair.Key];                    break;
                        }
                    }
                    catch
                    {
                        broken = true;
                        break;
                    }
                }
                if (broken)
                {
                    continue;
                }

                //going through other columns
                foreach (KeyValuePair<string, DataTypeWindow.DataTypeResult> pair in other)
                {
                    if (row[pair.Key] == DBNull.Value)
                    {
                        if (pair.Value.Option == 1 || pair.Value.Option == 2)
                        {
                            newRow[pair.Key] = DBNull.Value;
                            List<int> list;
                            if (!bad.TryGetValue(pair.Key, out list))
                            {
                                bad.Add(pair.Key, list = new List<int>());
                            }
                            list.Add(rowNum);
                        }
                        else if(pair.Value.Option == 4)
                        {
                            newRow[pair.Key] = pair.Value.Value;
                        }
                        continue;
                    }

                    try
                    {
                        switch (pair.Value.DataType)
                        {
                            case DataTypeWindow.DataType.Numeric: newRow[pair.Key] = Convert.ToInt32(row[pair.Key]);   break;
                            case DataTypeWindow.DataType.Real:    newRow[pair.Key] = Convert.ToDecimal(row[pair.Key]); break;
                            default:                              newRow[pair.Key] = row[pair.Key];                    break;
                        }
                    }
                    catch
                    {
                        if (pair.Value.Option == 0)
                        {
                            newRow[pair.Key] = DBNull.Value;
                        }
                        else if (pair.Value.Option == 1 || pair.Value.Option == 2)
                        {
                            newRow[pair.Key] = DBNull.Value;
                            List<int> list;
                            if (!bad.TryGetValue(pair.Key, out list))
                            {
                                bad.Add(pair.Key, list = new List<int>());
                            }
                            list.Add(rowNum);
                        }
                        else
                        {
                            newRow[pair.Key] = pair.Value.Value;
                        }
                    }
                }

                ++rowNum;
                table.Rows.Add(newRow);
            }

            //counting and replacing bad values for other methods (median, mean, custom value)
            foreach(KeyValuePair<string, List<int>> pair in bad) {
                if (table.Columns[pair.Key].DataType == typeof(int))
                {
                    int value;
                    if (other[pair.Key].Option == 1)
                    {
                        GetMedian(table, pair.Key, out value);
                    }
                    else
                    {
                        GetMean(table, pair.Key, out value);
                    }

                    foreach (int row in pair.Value)
                    {
                        table.Rows[row][pair.Key] = value;
                    }
                }
                else
                {
                    decimal value;
                    if (other[pair.Key].Option == 1)
                    {
                        GetMedian(table, pair.Key, out value);
                    }
                    else
                    {
                        GetMean(table, pair.Key, out value);
                    }

                    foreach (int row in pair.Value)
                    {
                        table.Rows[row][pair.Key] = value;
                    }
                }

            }

            Data = table;

            OnFinished(EventArgs.Empty);
        }

        private void GetMean(DataTable table, string columnName, out int r)
        {
            r = (int)Math.Round(table.AsEnumerable().Where(row => row[columnName] != DBNull.Value).Average(row => (int)row[columnName]));
        }
        private void GetMean(DataTable table, string columnName, out decimal r)
        {
            r = table.AsEnumerable().Where(row => row[columnName] != DBNull.Value).Average(row => (decimal)row[columnName]);
        }
        private void GetMedian(DataTable table, string columnName, out int r)
        {
            var orderedPersons = table.AsEnumerable().Select(row => row[columnName]).Where(cell => cell != DBNull.Value).OrderBy(x => x);
            r = (int)orderedPersons.ElementAt((orderedPersons.Count() - 1) / 2);
        }
        private void GetMedian(DataTable table, string columnName, out decimal r)
        {
            var orderedPersons = table.AsEnumerable().Select(row => row[columnName]).Where(cell => cell != DBNull.Value).OrderBy(cell => cell);
            r = (decimal)orderedPersons.ElementAt(orderedPersons.Count() / 2) / 2 + (decimal)orderedPersons.ElementAt((orderedPersons.Count() - 1) / 2) / 2;
        }


    }
}
