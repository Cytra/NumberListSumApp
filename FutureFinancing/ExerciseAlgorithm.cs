using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FutureFinancing.Helpers;

namespace FutureFinancing
{
    public static class ExerciseAlgorithm
    {
        public static int GetHighestNumberSum(List<List<int>> numbers)
        {
            var result = 0;
            //Initialize if first numer is odd or even
            var checkOddnumbers = NumberHelper.FirstNumberInListIsAnOddNumber(numbers);

            //Sort through list of number lists
            foreach (List<int> numberList in numbers)
            {
                //Remove Odd or Even numbers from the list
                var sortedNumberList = checkOddnumbers ? NumberHelper.SortOddNumbers(numberList) : NumberHelper.SortEvenNumbers(numberList);

                var highestNumberInList = 0;
                //Sort through all numbers in the list to find the highest number and add it
                foreach (int number in sortedNumberList)
                {
                    if (number > highestNumberInList)
                    {
                        highestNumberInList = number;
                    }
                }

                result += highestNumberInList;

                //Next number in list needs to be odd if was even and other way around
                checkOddnumbers = !checkOddnumbers;
            }

            return result;
        }
    }
}
