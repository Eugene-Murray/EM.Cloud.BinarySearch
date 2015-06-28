using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EM.Cloud.BinarySearch;

namespace EM.Cloud.BinarySearch.Tests
{
    [TestClass]
    public class SearchServiceFixture
    {
        public static ISearchService _searchService;

        [TestInitialize]
        public void Init()
        {
            _searchService = new SearchService();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void BinarySearchIterative_Exception()
        {
            // Assign
            int[] inputArray = { 1, 2, 3, 4, 5 };
            int? searchKey = null;
            var min = 0;
            var max = inputArray.Length - 1;
            var expectedResult = 3;

            // Act
            var actualResult = _searchService.BinarySearchIterative(inputArray, searchKey, min, max);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BinarySearchIterative_Success()
        {
            // Assign
            int[] inputArray = { 1, 2, 3, 4, 5 };
            var searchKey = 4;
            var min = 0;
            var max = inputArray.Length - 1;
            var expectedResult = 4;

            // Act
            var actualResult = _searchService.BinarySearchIterative(inputArray, searchKey, min, max);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BinarySearchIterative_ExpectNil_Success()
        {
            // Assign
            int[] inputArray = { 1, 2, 3, 4, 5 };
            var searchKey = 8;
            var min = 0;
            var max = inputArray.Length - 1;
            var expectedResult = "Nil";

            // Act
            var actualResult = _searchService.BinarySearchIterative(inputArray, searchKey, min, max);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FindWinner_Success()
        {
            // Assign
            int[] inputArray = { 6, 20, 6, 5, 4, 6, 5, 5 };
            var expectedResult = 6;

            // Act
            var actualResult = _searchService.FindWinner(inputArray);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
