using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace graunt
{
    // this class contains statistical functions
    public static class StatisticalFunctions
    {
        public static decimal Mean(DataTable table, string columnName)
        {
            int n = 0;
            decimal mean = 0;
            foreach (DataRow row in table.Rows)
            {
                if (row[columnName] == DBNull.Value)
                {
                    continue;
                }

                decimal x;

                if (row[columnName].GetType() == typeof(decimal))
                {
                    x = (decimal)row[columnName];
                }
                else
                {
                    x = (int)row[columnName];
                }

                n++;

                if (n == 1)
                {
                    mean = x;
                }
                else
                {
                    mean = mean + (x - mean) / n;
                }
            }
            return mean;
        }

        public static decimal Median(DataTable table, string columnName)
        {
            var ordered = table.AsEnumerable().Select(row => row[columnName]).Where(cell => cell != DBNull.Value).OrderBy(cell => cell);
            decimal d1, d2;

            if (ordered.ElementAt(ordered.Count() / 2).GetType() == typeof(decimal))
            {
                d1 = (decimal)ordered.ElementAt(ordered.Count() / 2);
            }
            else
            {
                d1 = (int)ordered.ElementAt(ordered.Count() / 2);
            }

            if (ordered.Count() % 2 == 1)
            {
                return d1;
            }
            
            if (ordered.ElementAt((ordered.Count() - 1) / 2).GetType() == typeof(decimal))
            {
                d2 = (decimal)ordered.ElementAt((ordered.Count() - 1) / 2);
            }
            else
            {
                d2 = (int)ordered.ElementAt((ordered.Count() - 1) / 2);
            }

            if ( d1 == d2)
            {
                return d1;
            }
            else if (d1 < (decimal.MaxValue/2)-1 && d2 < (decimal.MaxValue/2)-1)
            {
                return (d1 + d2) / 2;
            }
            else
            {
                return d1/2 + d2/2;
            }
        }

        // Rewrite for C# from http://www.johndcook.com/standard_deviation.html
        public static decimal Variance(DataTable table, string columnName)
        {
            int n = 0;
            decimal oldMean = 0, newMean, oldSum = 0, newSum = 0;

            foreach (DataRow row in table.Rows)
            {
                if (row[columnName] == DBNull.Value)
                {
                    continue;
                }

                decimal x;

                if (row[columnName].GetType() == typeof(decimal))
                {
                    x = (decimal)row[columnName];
                }
                else
                {
                    x = (int)row[columnName];
                }

                n++;

                if (n == 1)
                {
                    oldMean = newMean = x;
                    oldSum = 0.0M;
                }
                else
                {
                    newMean = oldMean + (x - oldMean) / n;
                    newSum = oldSum + (x - oldMean) * (x - newMean);

                    oldMean = newMean;
                    oldSum = newSum;
                }
            }

            return ((n > 1) ? newSum / (n - 1) : 0.0M);
        }

        public static decimal StandardDeviation(DataTable table, string columnName)
        {
            return Sqrt(Variance(table, columnName));
        }

        //Main idea from http://stackoverflow.com/a/6755197
        private static decimal Sqrt(decimal value)
        {
            if (value < 0) throw new OverflowException("Cannot calculate square root from a negative number.");

            decimal current = (decimal)Math.Sqrt((double)value), previous;
            do
            {
                previous = current;
                if (previous == 0.0M)
                {
                    return 0;
                }
                current = (previous + value / previous) / 2;
            }

            while (Math.Abs(previous - current) > 0.0M);
            return current;
        }
    }
}
