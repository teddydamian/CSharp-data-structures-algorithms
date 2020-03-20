using System;
using Xunit;
using BinarySearch;

namespace BinaryTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Test to if using bigger array.
        /// </summary>
        /// <param name="array">Given array</param>
        /// <param name="checker">Number used to check</param>
        /// <param name="expected">Expected result</param>
        [Theory]
        [InlineData(new int[8] { 10, 20, 30, 40, 50, 60, 70, 80 }, 30, 2)]
        [InlineData(new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }, 80, 7)]

        public void CheckForBiggerArray(int[] array, int checker, int expected)
        {
            Assert.Equal(expected, Program.BinarySearch(array, checker)); ;
        }

        /// <summary>
        /// Test to if using smallr array.
        /// </summary>
        /// <param name="array">Given array</param>
        /// <param name="checker">Number used to check</param>
        /// <param name="expected">Expected result</param>
        [Theory]
        [InlineData(new int[4] { 10, 20, 30, 40 }, 30, 2)]
        [InlineData(new int[2] { 10, 20 }, 20, 1)]

        public void CheckForSmallerArray(int[] array, int checker, int expected)
        {
            Assert.Equal(expected, Program.BinarySearch(array, checker)); ;
        }

        /// <summary>
        /// Test to get -1 as a result if it doesnt exist in array.
        /// </summary>
        [Fact]
        public void TestingIfNumberDoesNotExistInArray()
        {
            int[] array = new int[6] { 10, 20, 30, 40, 50, 60 };
            Assert.Equal(-1, Program.BinarySearch(array, 2));
        }

    }
}
