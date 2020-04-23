using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;
using QuickSort;

namespace QuickSortTest
{
    public class UnitTest1
    {
        /// <summary>
        /// This test takes in 4 different arrays, and sort them.
        /// </summary>
        [Theory]
        [InlineData(new int[] { 8, 4, 23, 42, 16, 15 }, new int[] { 4, 8, 15, 16, 23, 42 })]
        [InlineData(new int[] { 20, 18, 12, 8, 5, -2 }, new int[] { -2, 5, 8, 12, 18, 20 })]
        [InlineData(new int[] { 5, 12, 7, 5, 5, 7 }, new int[] { 5, 5, 5, 7, 7, 12 })]
        [InlineData(new int[] { 2, 3, 5, 7, 13, 11 }, new int[] { 2, 3, 5, 7, 11, 13 })]
        public void TestForAllArrayTypes(int[] input, int[] expected)
        {
            int[] result = QuickSort.Program.QuickSortArray(input, 0, input.Length - 1);

            Assert.Equal(expected, result);
        }
    }
}
