using CsvReadingAndDrowingMap.Models;
using ExcelDataReader;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CsvReadingAndDrowingMap.Controllers
{
    public class HomeController : Controller
    {
        private static List<DataDto>? dataList { get; set; }

        public HomeController()
        {
            PopulateDataListFromFile();
        }
        private void PopulateDataListFromFile()
        {
            if (dataList == null)
            {
                dataList = new List<DataDto>();
                var fileName = $"{Directory.GetCurrentDirectory()}{@"\wwwroot\data.xlsx"}";
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                using (var stream = System.IO.File.Open(fileName, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                        while (reader.Read())
                        {
                            var row = reader.GetValue(0).ToString();
                            var rowItems = row.Replace("\"", string.Empty).Split(";");
                            dataList.Add(new DataDto()
                            {
                                STATION_ID = rowItems[0].ToString(),
                                SITE_NAME = rowItems[1],
                                ZDALY_GAS_BRAND = rowItems[2].ToString(),
                                ADDRESS = rowItems[3].ToString(),
                                CITY = rowItems[4].ToString(),
                                STATE = rowItems[5].ToString(),
                                ZIP = rowItems[6].ToString(),
                                COUNTY_NAME = rowItems[7].ToString(),
                                PRICING_ZONE = rowItems[8].ToString(),
                                CLUSTER_MEDIAN_PRICE = rowItems[9].ToString(),
                                CLIENT_MARKET_PRICE = rowItems[10].ToString(),
                                LATITUDE = rowItems[11].ToString(),
                                LONGITUDE = rowItems[12].ToString(),

                            });
                        }
                }dataList.RemoveAt(0);
            }
        }

        public IActionResult Index()
        {
             return View(dataList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}