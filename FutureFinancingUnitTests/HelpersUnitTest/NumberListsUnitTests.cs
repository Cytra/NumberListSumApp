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
    public class NumberListsUnitTests
    {
        [TestMethod]
        public void SortOddNumbersUnitTest1()
        {
            var numbers = new List<int>(){10,11,15,16,17,22,33};
            var result = NumberHelper.SortOddNumbers(numbers);
            CollectionAssert.AreEqual(result, new List<int>(){11,15,17,33});
        }

        [TestMethod]
        public void SortOddNumbersUnitTest2()
        {
            var numbers = new List<int>() { 124, 256, 11, 253, 367 };
            var result = NumberHelper.SortOddNumbers(numbers);
            CollectionAssert.AreEqual(result, new List<int>() { 11,253,367 });
        }

        [TestMethod]
        public void SortOddNumbersUnitTest3()
        {
            var numbers = new List<int>() { 10245, 2658, 12345, 4578 };
            var result = NumberHelper.SortOddNumbers(numbers);
            CollectionAssert.AreEqual(result, new List<int>() { 10245, 12345 });
        }

        [TestMethod]
        public void SortEvenNumbersUnitTest1()
        {
            var numbers = new List<int>() { 10, 11, 15, 16, 17, 22, 33 };
            var result = NumberHelper.SortEvenNumbers(numbers);
            CollectionAssert.AreEqual(result, new List<int>() { 10, 16, 22 });
        }

        [TestMethod]
        public void SortEvenNumbersUnitTest2()
        {
            var numbers = new List<int>() { 124, 256, 11, 253, 367 };
            var result = NumberHelper.SortEvenNumbers(numbers);
            CollectionAssert.AreEqual(result, new List<int>() { 124, 256 });
        }

        [TestMethod]
        public void SortEvenNumbersUnitTest3()
        {
            var numbers = new List<int>() { 10245, 2658, 12345, 4578 };
            var result = NumberHelper.SortEvenNumbers(numbers);
            CollectionAssert.AreEqual(result, new List<int>() { 2658, 4578 });
        }

        [TestMethod]
        public void FirstNumberInListIsAnOddNumberTrueUnitTest1()
        {
            var numbers = new List<List<int>> {new List<int>() {1}, new List<int>() {2, 3}};
            var result = NumberHelper.FirstNumberInListIsAnOddNumber(numbers);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void FirstNumberInListIsAnOddNumberTrueUnitTest2()
        {
            var numbers = new List<List<int>> { new List<int>() { 55 }, new List<int>() { 2, 3 } };
            var result = NumberHelper.FirstNumberInListIsAnOddNumber(numbers);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void FirstNumberInListIsAnOddNumberFalseUnitTest1()
        {
            var numbers = new List<List<int>> { new List<int>() { 2 }, new List<int>() { 2, 3 } };
            var result = NumberHelper.FirstNumberInListIsAnOddNumber(numbers);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void FirstNumberInListIsAnOddNumberFalseUnitTest2()
        {
            var numbers = new List<List<int>> { new List<int>() { 256 }, new List<int>() { 2, 3 } };
            var result = NumberHelper.FirstNumberInListIsAnOddNumber(numbers);
            Assert.IsFalse(result);
        }
    }
}
