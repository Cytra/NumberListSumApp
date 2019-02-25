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
    public class StringHelperUnitTests
    {
        [TestMethod]
        public void GetNumberListFromStringUnitTest1()
        {
            var dataString = "215\r\n14 25\r\n45 78 98";
            var result = StringHelper.GetNumberListFromString(dataString);
            CollectionAssert.AreEqual( new List<int>(){215}, result[0]);
            CollectionAssert.AreEqual(new List<int>() {14, 25}, result[1]);
            CollectionAssert.AreEqual(new List<int>() {45, 78, 98}, result[2]);
        }

        [TestMethod]
        public void GetNumberListFromStringUnitTest2()
        {
            var dataString = "58\r\n68 47 784\r\n111 225 669";
            var result = StringHelper.GetNumberListFromString(dataString);
            CollectionAssert.AreEqual(new List<int>() { 58 }, result[0]);
            CollectionAssert.AreEqual(new List<int>() { 68, 47, 784 }, result[1]);
            CollectionAssert.AreEqual(new List<int>() { 111, 225, 669 }, result[2]);
        }
    }
}
