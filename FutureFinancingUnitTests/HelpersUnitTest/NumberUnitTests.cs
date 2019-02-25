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
    public class NumberUnitTests
    {
        [TestMethod]
        public void IsOddNumberTestTrue1()
        {
            var number = 1;
            var result = NumberHelper.IsOddNumber(number);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsOddNumberTestTrue2()
        {
            var number = 21;
            var result = NumberHelper.IsOddNumber(number);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsOddNumberTestTrue3()
        {
            var number = 1589;
            var result = NumberHelper.IsOddNumber(number);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsOddNumberTestFalse1()
        {
            var number = 2;
            var result = NumberHelper.IsOddNumber(number);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsOddNumberTestFalse2()
        {
            var number = 58;
            var result = NumberHelper.IsOddNumber(number);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsOddNumberTestFalse3()
        {
            var number = 2258;
            var result = NumberHelper.IsOddNumber(number);
            Assert.IsFalse(result);
        }
    }
}
