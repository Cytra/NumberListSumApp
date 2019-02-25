using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureFinancing.Helpers
{
    public static class NumberHelper
    {
        public static bool IsOddNumber(int number)
        {
            return number % 2 == 1;
        }

        public static List<int> SortOddNumbers(List<int> numberList)
        {
            var result = new List<int>();
            foreach (var num in numberList)
            {
                if (IsOddNumber(num))
                {
                    result.Add(num);
                }
            }
            return result;
        }

        public static List<int> SortEvenNumbers(List<int> numberList)
        {
            var result = new List<int>();
            foreach (var num in numberList)
            {
                if (!IsOddNumber(num))
                {
                    result.Add(num);
                }
            }
            return result;
        }

        public static int SortHighestNumber(List<int> numberList)
        {
            int result = int.MinValue;

            foreach (var num in numberList)
            {
                if (num > result)
                {
                    result = num;
                }
            }
            return result;
        }

        public static bool FirstNumberInListIsAnOddNumber(List<List<int>> numberList)
        {
            return IsOddNumber(numberList[0][0]);
        }
    }
}
