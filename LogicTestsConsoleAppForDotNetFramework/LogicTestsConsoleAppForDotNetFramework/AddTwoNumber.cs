using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTestsConsoleAppForDotNetFramework
{
    /// <summary>
    /// Given two non-negative integers, num1 and num2 represented as string, return the sum of num1 and num2 as a string.
    /// 
    /// You must solve the problem without using any built-in library for handling large integers (such as BigInteger). You must also not convert the inputs to integers directly.
    /// 
    /// Example 1:
    /// 
    /// Input: num1 = "11", num2 = "123"
    /// Output: "134"
    /// Example 2:
    /// 
    /// Input: num1 = "456", num2 = "77"
    /// Output: "533"
    /// 
    /// Constraints:
    /// 
    /// 1 <= num1.length, num2.length <= 104
    /// num1 and num2 consist of only digits.
    /// num1 and num2 don't have any leading zeros except for the zero itself.
    /// </summary>
    public class AddTwoStringNumber
    {
        public static string AddStringNumbers(string num1, string num2)
        {
            num1 = string.IsNullOrWhiteSpace(num1) ? "123" : num1;
            num2 = string.IsNullOrWhiteSpace(num2) ? "1234" : num2;

            var num1Arr = num1.ToCharArray();
            var num2Arr = num2.ToCharArray();

            string tempResult = "";
            var divideByRemainder = 0;
            int num1Length = num1.Length,
                num2Length = num2.Length;
            do
            {
                num1Length--;
                num2Length--;
                int tempSum = divideByRemainder;

                if (num1Length >= 0)
                    tempSum += Convert.ToInt32(num1Arr[num1Length].ToString());
                if (num2Length >= 0)
                    tempSum += Convert.ToInt32(num2Arr[num2Length].ToString());

                if (tempSum / 10 == 0)
                {
                    tempResult = tempResult + tempSum.ToString();
                    divideByRemainder = 0;
                }
                else
                {
                    divideByRemainder = tempSum / 10;
                    tempResult = tempResult + (tempSum % 10).ToString();
                }
            } while (num1Length > 0 || num2Length > 0);

            var arr = tempResult.ToCharArray();
            Array.Reverse(arr);
            string result = new string(arr); 
            return result;
        }
    }
}
