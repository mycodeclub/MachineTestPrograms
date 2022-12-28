using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTestsConsoleAppForDotNetFramework
{
    public static class CountRepeatedCharactersInString
    {
        public static void ShowCharCount(string inputString)
        {
            if (string.IsNullOrWhiteSpace(inputString))
                inputString = "Some Text String";
            var charArray = inputString.ToCharArray();
            var result = charArray.GroupBy(x => x)
                   .Select(z => new
                   {
                       alphabet = z.Key,
                       count = z.Select(x => x).Count()
                   }).ToList();

            foreach (var item in result)
                Console.WriteLine(item);
            Console.WriteLine("\n Press Enter to continue ...");
            Console.ReadLine();
        }
    }
}
