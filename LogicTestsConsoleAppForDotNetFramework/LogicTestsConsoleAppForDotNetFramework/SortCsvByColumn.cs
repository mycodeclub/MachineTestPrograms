using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTestsConsoleAppForDotNetFramework
{
    public static class SortCsvByColumn
    {

        public static string Sort(string csvFileContent)
        {
            if (string.IsNullOrWhiteSpace(csvFileContent))
                csvFileContent = @"myjinxin2015;raulbc777;smile67;Dentzil;SteffenVogel_79\n
                                 17945;10091;10088;3907;10132\n
                                 2;12;13;48;11";
            var rows = csvFileContent.Split('\n');
            var csvHeaders = rows[0].Split(';').ToList();
            var csvShortedHeader = csvHeaders.OrderBy(a => a).ToList();

            var csvColumns = new List<List<string>>();
            for (int i = 0; i < csvHeaders.Count(); i++)
                csvColumns.Add(new List<string>() { csvHeaders[i] });

            for (int r = 1; r < rows.Length; r++)
            {
                var rowData = rows[r].Split(';');
                for (int i = 0; i < rowData.Length; i++)
                    csvColumns[i].Add(rowData[i].Trim());
            }

            var csvShortedColumns = new List<List<string>>();
            csvShortedHeader.ForEach(sh =>
            {
                foreach (var c in csvColumns)
                    if (c.Contains(sh))
                        csvShortedColumns.Add(c);
            });

            StringBuilder newSb = new StringBuilder();
            for (int r = 0; r < rows.Count(); r++)
            {
                for (int c = 0; c < csvShortedColumns.Count(); c++)
                    if (c < csvShortedColumns.Count() - 1)
                        newSb.Append(csvShortedColumns[c][r] + ";");
                    else if (r < rows.Count() - 1)
                        newSb.Append(csvShortedColumns[c][r] + "\n");
            }

            var shortedCsvString = newSb.ToString().Trim();
            return shortedCsvString;
        }

    }
}
