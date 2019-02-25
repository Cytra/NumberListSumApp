using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FutureFinancing.Helpers;

namespace FutureFinancing
{
    class Program
    {
        static void Main(string[] args)
        {   
            var numbersString = StringHelper.GetNumberListFromString(Properties.Resources.FutureFinanceData.ToString());
            var numberSum = ExerciseAlgorithm.GetHighestNumberSum(numbersString);
            Console.WriteLine($"Exercise answer - {numberSum}");
            Console.ReadKey();
        }
    }
}
