using System;
using QueueWithStacks.Classes;
using Xunit;

namespace QueueTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Test to see if new value added to the bottom of queue using string
        /// </summary>
        [Fact]
        public void TestToSeeIfEnqueueWorks()
        {
            PseudoQueue pseudo = new PseudoQueue();

            pseudo.One.Push(20);
            pseudo.One.Push(30);
            pseudo.One.Push(40);
     
            string input = pseudo.Enqueue(10);
            string expected = "Top of Stack -> 40 -> 30 -> 20 -> 10 -> NULL";
            Assert.Equal(expected, input);
        }

        /// <summary>
        /// Test to see if new value added and test using size
        /// </summary>
        [Fact]
        public void TestEnqueueUsingSize()
        {
            PseudoQueue pseudo = new PseudoQueue();

            pseudo.One.Push(20);
            pseudo.One.Push(30);
            pseudo.One.Push(40);
            pseudo.One.Push(50);
            pseudo.One.Push(60);
            pseudo.Enqueue(10);
            Assert.Equal(6, pseudo.One.Size);
        }

        /// <summary>
        /// Test to see if multiple Enqueues works
        /// </summary>
        [Fact]
        public void TestForMultipleEnqueues()
        {
            PseudoQueue pseudo = new PseudoQueue();

            // Bottom will be 40, 50, 60
            pseudo.One.Push(40);
            pseudo.One.Push(50);
            pseudo.One.Push(60);

            pseudo.Enqueue(10); // 10,40,50,60
            pseudo.Enqueue(20); // 20,10,40,50,60
            pseudo.Enqueue(30); // 30,20,10,40,50,60

            string input = pseudo.Enqueue(70);
            string expected = "Top of Stack -> 60 -> 50 -> 40 -> 10 -> 20 -> 30 -> 70 -> NULL";
            Assert.Equal(expected, input);
        }

        /// <summary>
        /// Test to see if Dequeue removes the top using string
        /// </summary>
        [Fact]
        public void DequeueUsingStringAsResult()
        {
            PseudoQueue pseudo = new PseudoQueue();

            pseudo.One.Push(10);
            pseudo.One.Push(20);
            pseudo.One.Push(30);
            pseudo.One.Push(40);

            string input = pseudo.Dequeue();
            string expected = "Top of Stack -> 30 -> 20 -> 10 -> NULL";
            Assert.Equal(expected, input);
        }

        /// <summary>
        /// Test for Dequeue using Size
        /// </summary>
        [Fact]
        public void DequeueUsingSizeAsResult()
        {
            PseudoQueue pseudo = new PseudoQueue();

            pseudo.One.Push(10);
            pseudo.One.Push(20);
            pseudo.One.Push(30);

            pseudo.Dequeue();
            Assert.Equal(2, pseudo.One.Size);
        }

        /// <summary>
        /// Test for multiple Dequeue
        /// </summary>
        [Fact]
        public void MultipleDequeues()
        {
            PseudoQueue pseudo = new PseudoQueue();

            pseudo.One.Push(10);
            pseudo.One.Push(20);
            pseudo.One.Push(30);
            pseudo.One.Push(40);
            pseudo.One.Push(50);
            pseudo.One.Push(60);

            pseudo.Dequeue();
            pseudo.Dequeue();
            pseudo.Dequeue();
            Assert.Equal(3, pseudo.One.Size);
        }

        /// <summary>
        /// Test to see if Exception is thrown on Dequeueing empty stack
        /// </summary>
        [Fact]
        public void TestForExceptionForDequeueOnEmptyStack()
        {
            PseudoQueue pseudo = new PseudoQueue();
            Exception ex = Record.Exception(() => pseudo.Dequeue());
            Assert.IsType<Exception>(ex);
        }

        /// <summary>
        /// Test to see if Enqueue works on Empty stack
        /// </summary>
        [Fact]
        public void TestForEnqueingOnEmptyStack()
        {
            PseudoQueue pseudo = new PseudoQueue();
            string input = pseudo.Enqueue(10);
            string expected = "Top of Stack -> 10 -> NULL";
            Assert.Equal(expected, input);
        }

        /// <summary>
        /// Test to see if multiple Enqueues works on Empty stack
        /// </summary>
        [Fact]
        public void TestForMultipleEnqueuesOnEmptyStack()
        {
            PseudoQueue pseudo = new PseudoQueue();
            pseudo.Enqueue(10);
            pseudo.Enqueue(20);
            pseudo.Enqueue(30);

            string input = pseudo.Enqueue(40);
            string expected = "Top of Stack -> 10 -> 20 -> 30 -> 40 -> NULL";
            Assert.Equal(expected, input);
        }
    }
}
