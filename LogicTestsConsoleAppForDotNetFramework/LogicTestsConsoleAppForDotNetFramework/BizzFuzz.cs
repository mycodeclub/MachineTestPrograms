using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTestsConsoleAppForDotNetFramework
{
    internal class BizzFuzz
    {
        /// <summary>
        /// In traditional FizzBuzz, you are asked to print the numbers from 1 to 100,
        /// but replacing every multiple of 3 with "Fizz",
        /// every multiple of 5 with "Buzz", 
        /// and every multiple of both 3 and 5 (i.e. 15) with "FizzBuzz".
        /// </summary>
        public void PrintBizzFuzz()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("Bizz Fuzz");
                else if (i % 5 == 0) Console.WriteLine("Bizz");
                else if (i % 3 == 0 ) Console.WriteLine("Fuzz");
                else  Console.WriteLine(i);
            }
        }
    }
}
