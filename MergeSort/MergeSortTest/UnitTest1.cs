using System;
using MergeSort;
using Xunit;

namespace MergeSortTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 8, 4, 23, 42, 16, 15 }, new int[] { 4, 8, 15, 16, 23, 42 })]
        public void TestArray1(int[] input, int[] expected)
        {
            int[] before = input;
            int[] result = Program.MergeSortArray(before);

            Assert.Equal(expected, result);
        }

        //[Fact]
        //public void TestArray1()
        //{
        //    int[] before = new int[] { 8, 4, 23, 42, 16, 15 };
        //    int[] expected = Program.MergeSortArray(before);
        //    int[] result = new int[] { 4, 8, 15, 16, 23, 42 };

        //    Assert.Equal(result, expected);
        //}
    }
}
