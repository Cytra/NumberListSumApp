using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FutureFinancing.Helpers;

namespace FutureFinancingUnitTests.HelpersUnitTest
{
    [TestClass]
    public class SortHighestNumberUnitTests
    {
        [TestMethod]
        public void SortHighestNumberUnitTest1()
        {
            var numbers = new List<int>() { 10, 11, 15, 16, 17, 22, 33 };
            var result = NumberHelper.SortHighestNumber(numbers);
            Assert.AreEqual(33,result);
        }

        [TestMethod]
        public void SortHighestNumberUnitTest2()
        {
            var numbers = new List<int>() { 110,225,654,12,35 };
            var result = NumberHelper.SortHighestNumber(numbers);
            Assert.AreEqual(654, result);
        }

        [TestMethod]
        public void SortHighestNumberUnitTest3()
        {
            var numbers = new List<int>() { 10, 11, 15, 16, 17, 22, 33, 65, 584, 457, 782 };
            var result = NumberHelper.SortHighestNumber(numbers);
            Assert.AreEqual(782, result);
        }
    }
}
