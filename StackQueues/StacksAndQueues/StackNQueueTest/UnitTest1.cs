using System;
using StacksAndQueues.Classes;
using Xunit;

namespace StackNQueueTest
{
    public class UnitTest1
    {
        [Fact]
        public void NewStackInstantiation()
        {
            Stack stack = new Stack();
            string expected = stack.ToString();
            string input = "Top of Stack -> NULL";
            Assert.Equal(input, expected);
        }
    }
}
