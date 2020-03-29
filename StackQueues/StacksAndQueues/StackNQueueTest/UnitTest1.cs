using System;
using StacksAndQueues.Classes;
using Xunit;

namespace StackNQueueTest
{
    /// <summary>
    /// Tests for Stacks
    /// </summary>
    public class Stacks
    {
        /// <summary>
        /// Can successfully instantiate an empty stack.
        /// </summary>
        [Fact]
        public void NewStackInstantiation()
        {
            Stack stack = new Stack();
            string expected = stack.ToString();
            string input = "Top of Stack -> NULL";
            Assert.Equal(expected, input);
        }

        /// <summary>
        /// Test to see if Node is added with Push Method.
        /// </summary>
        [Fact]
        public void AddNodeIntoStackWithPush()
        {
            Stack stack = new Stack();
            stack.Push(10);
            Assert.Equal(1, stack.Size);
        }

        /// <summary>
        /// Add multiple Nodes to Stack
        /// </summary>
        [Fact]
        public void AddMultipleNodesIntoStackWithPush()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(100);
            Assert.Equal(2, stack.Size);
        }

        /// <summary>
        /// Test to see if Pop Method will remove the top Node.
        /// </summary>
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

        /// <summary>
        /// Test to empty stack with multiple Pops.
        /// </summary>
        [Fact]
        public void EmptyTheWholeStackWithMultiplePops()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Pop();
            stack.Pop();
            int input = stack.Size;
            int expected = 0;
            Assert.Equal(expected, input);
        }

        /// <summary>
        /// Test to see if Peek method will return value of the top node.
        /// </summary>
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

        /// <summary>
        /// Bool test to see if stack is empty
        /// </summary>
        [Fact]
        public void CheckIfStackIsEmpty()
        {
            Stack stack = new Stack();
            bool input = stack.IsEmpty();
            Assert.True(input);
        }

        /// <summary>
        /// Test to see if exception is raised when using Pop on empty stack.
        /// </summary>
        [Fact]
        public void PopWithEmptyStack()
        {
            Stack stack = new Stack();
            Exception ex = Record.Exception(() => stack.Pop());
            Assert.IsType<NullReferenceException>(ex);
        }

        /// <summary>
        /// Test to see if exception is raised when using Peek on empty stack.
        /// </summary>
        [Fact]
        public void PeekWithEmptyStack()
        {
            Stack stack = new Stack();
            Exception ex = Record.Exception(() => stack.Peek());
            Assert.IsType<Exception>(ex);
        }

    }


    /// <summary>
    /// Test for Queues
    /// </summary>
    public class QueueTests
    {
        /// <summary>
        /// Can successfully enqueue into a queue.
        /// </summary>
        [Fact]
        public void TestForEnqueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            int input = queue.Size;
            int expected = 1;
            Assert.Equal(expected, input);
        }

        /// <summary>
        /// Can successfully do multiple enqueues into a queue.
        /// </summary>
        [Fact]
        public void TestForMultipleEnqueues()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            int input = queue.Size;
            int expected = 3;
            Assert.Equal(expected, input);
        }

        /// <summary>
        /// Can successfully dequeue out of a queue the expected value
        /// </summary>
        [Fact]
        public void DequeueOutOfAQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            int input = queue.Dequeue();
            int expected = 10;
            Assert.Equal(expected, input);
        }

        /// <summary>
        /// Can successfully check the value of the front node
        /// </summary>
        [Fact]
        public void PeekOnQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            int input = queue.Peek();
            int expected = 10;
            Assert.Equal(expected, input);
        }

        /// <summary>
        /// Raises exception if Dequeue is called on empty Queue.
        /// </summary>
        [Fact]
        public void DequeueWithEmptyQueue()
        {
            Queue queue = new Queue();
            Exception ex = Record.Exception(() => queue.Peek());
            Assert.IsType<Exception>(ex);
        }

        /// <summary>
        /// Raises exception if Peek is called on empty Queue.
        /// </summary>
        [Fact]
        public void PeekWithEmptyQueue()
        {
            Queue queue = new Queue();
            Exception ex = Record.Exception(() => queue.Peek());
            Assert.IsType<Exception>(ex);
        }

        /// <summary>
        /// Can successfully empty a queue after multiple dequeues
        /// </summary>
        [Fact]
        public void MultipleDequeueToEmptyQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            Exception ex = Record.Exception(() => queue.Peek());
            Assert.IsType<Exception>(ex);
        }

        /// <summary>
        /// Can successfully instantiate and Empty queue
        /// </summary>
        [Fact]
        public void CanInstantiateEmptyQueue()
        {
            Queue queue = new Queue();
            int input = queue.Size;
            Assert.Equal(0, input);
        }

        /// <summary>
        /// Check if the queue is empty
        /// </summary>
        [Fact]
        public void CheckForEmptyQueue()
        {
            Queue queue = new Queue();
            Assert.True(queue.IsEmpty());
        }
    }
}
