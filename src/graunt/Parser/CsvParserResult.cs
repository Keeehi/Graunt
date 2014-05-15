using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Threading;

namespace graunt
{
    public class CsvParserResult
    {
        private bool partial;
        private int originalColumnNames;
        public int columns { get; private set; }
        public int rows { get; private set; }
        public ReadOnlyCollection<string> columnNames { get; private set; }
        public ReadOnlyCollection<int> recordsLength { get; private set; }
        private ReadOnlyCollection<List<string>> data;

        public CsvParserResult(bool partial, int originalColumnNames, int columns, int rows, ReadOnlyCollection<string> columnNames, ReadOnlyCollection<List<string>> data, ReadOnlyCollection<int> recordsLength)
        {
            this.partial = partial;
            this.originalColumnNames = originalColumnNames;
            this.columns = columns;
            this.rows = rows;
            this.columnNames = columnNames;
            this.data = data;
            this.recordsLength = recordsLength;
        }

        //converts inner values in to the datatable
        static public implicit operator DataTable(CsvParserResult csvParserResult)
        {
            DataTable result = new DataTable();
            result.Locale = Thread.CurrentThread.CurrentCulture;

            if (csvParserResult == null)
            {
                return null;
            }

            foreach (string columnName in csvParserResult.columnNames)
            {
                result.Columns.Add(columnName, typeof(string));
            }

            for (int row = 0; row < csvParserResult.rows; ++row)
            {
                DataRow dataRow = result.NewRow();

                for (int column = 0; column < csvParserResult.columns; ++column)
                {
                        dataRow[column] = csvParserResult.data[column][row];
                }

                result.Rows.Add(dataRow);
            }

            return result;
        }

        public bool IsPartial()
        {
            return this.partial;
        }

        public bool IsValid()
        {
            return recordsLength.Distinct().Count() == 1 && columns == recordsLength.First();
        }

        public int GetMostFrequentRecordLength()
        {
            if (IsValid())
            {
                return originalColumnNames;
            }

            if (originalColumnNames > 0)
            {
                return originalColumnNames;
            }

            if (recordsLength.Count() == 0)
            {
                throw new GeneralException();
            }

            var r1 = recordsLength.GroupBy(x => x).OrderByDescending(x => x.Count());
            var r2 = r1.Where(x => x.Count() == r1.First().Count()).Select(x => x.Key).OrderBy(x => x);
            return r2.ElementAt((r2.Count() - 1) / 2);
        }

    }
}
