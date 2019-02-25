using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureFinancing.Helpers
{
    public static class StringHelper
    {
        public static List<List<int>> GetNumberListFromString(string dataString)
        {
            var result = new List<List<int>>();
            //split string on new lines
            var stringLists = dataString.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (var stringList in stringLists)
            {
                //split string on spaces
                var stringNumbers = stringList.Split(new char[0]);
                var numberList = new List<int>();
                foreach (var numberString in stringNumbers)
                {
                    //Assuming that all strings are numbers
                    numberList.Add(int.Parse(numberString));
                }
                result.Add(numberList);
            }

            return result;
        }

    }
}
