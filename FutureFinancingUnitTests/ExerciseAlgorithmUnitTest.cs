using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FutureFinancing.Helpers;
using FutureFinancing;

namespace FutureFinancingUnitTests
{
    [TestClass]
    public class ExerciseAlgorithmUnitTest
    {
        [TestMethod]
        public void GetHighestNumberSumUnitTest1()
        {
            var numbersString = StringHelper.GetNumberListFromString(FutureFinancing.Properties.Resources.FutureFinanceTestData1.ToString());
            var numberSum = ExerciseAlgorithm.GetHighestNumberSum(numbersString);
            Assert.AreEqual(1512, numberSum);
        }
    }
}
