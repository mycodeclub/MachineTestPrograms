using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTestsConsoleAppForDotNetFramework
{
    public static class StarPrintTringle
    {
        public static void PrintStar(int n = 5)
        {
            //       *
            //      ***
            //     *****
            //    *******
            //   *********

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < (n - i); j++)
                    Console.Write(" ");
                var starsCount = 0; 
                do
                {
                    Console.Write("*");
                    starsCount++;
                } 
                while (starsCount < (i * 2) - 1);
                Console.WriteLine();
            }
        }
    }
}
