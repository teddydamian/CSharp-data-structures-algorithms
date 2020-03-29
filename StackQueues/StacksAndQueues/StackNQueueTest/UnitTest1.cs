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

        [Fact]
        public void CheckIfStackIsEmpty()
        {
            Stack stack = new Stack();
            bool input = stack.isEmpty();
            Assert.True(input);
        }

        [Fact]
        public void PopWithEmptyStack()
        {
            Stack stack = new Stack();
            Exception ex = Record.Exception(() => stack.Pop());
            Assert.IsType<NullReferenceException>(ex);
        }
        [Fact]
        public void PeekWithEmptyStack()
        {
            Stack stack = new Stack();
            Exception ex = Record.Exception(() => stack.Peek());
            Assert.IsType<Exception>(ex);
        }

    }
}
