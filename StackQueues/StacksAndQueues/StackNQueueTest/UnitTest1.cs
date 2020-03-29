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
            Assert.Equal(expected, input);
        }

        [Fact]
        public void AddNodeIntoStackWithPush()
        {
            Stack stack = new Stack();
            stack.Push(10);
            Assert.Equal(1, stack.Size);
        }
        [Fact]
        public void RemoveTopNodeWithPop()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            int input = stack.Pop();
            int expected = 20;
            Assert.Equal(expected, input);
        }

        [Fact]
        public void CheckTopValueWithPeek()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            int input = stack.Peek();
            int expected = 40;
            Assert.Equal(expected, input);
        }

        //
        //[Fact]
        //public void PopWithEmptyStack()
        //{
        //    Stack stack = new Stack();
        //    var expected = stack.Pop();

        //    NullReferenceException ex = Assert.Throws<NullReferenceException>(() => expected);

        //    Assert.Equal("System.NullReferenceException : Object reference not set to an instance of an object.", ex.Message);
        //}

    }
}
