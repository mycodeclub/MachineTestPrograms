using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTestsConsoleAppForDotNetFramework
{
    public static class ArraySorting
    {
        public static void SortMyArray(int[] intArray)
        {
            if (intArray == null || intArray.Length <= 0)
                intArray = new int[] { 9, 2, 4, 3, 1, 5 };

            //Array.Sort(intArray);
            //Array.Reverse(intArray);

            for (int i = 0; i < intArray.Length; i++)
            {
                var smallest = intArray[i];
                for (int j = i + 1; j < intArray.Length ; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        intArray[i] = intArray[i] + intArray[j]; // i=10, j=20 |  10 + 20  i=30
                        intArray[j] = intArray[i] - intArray[j]; // i=30, j=20 |  30 - 20  j=10
                        intArray[i] = intArray[i] - intArray[j]; // i=30, j=10 |  30 - 10  i=20
                    }
                }
            }
            foreach (int i in intArray)
                Console.WriteLine(i);
            Console.ReadLine();
        }

    }
}
