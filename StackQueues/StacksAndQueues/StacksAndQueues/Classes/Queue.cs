using System;
using StacksAndQueues.Classes;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }
        public int Size { get; set; } = 0;

        public Queue()
        {
            Front = null;
            Rear = null;
        }

        /// <summary>
        /// Method that adds a new node with that value to the back of the queue
        /// </summary>
        /// <param name="value">value of new Node</param>
        public void Enqueue(int value)
        {
            Node newNode = new Node(value);
            if(Rear != null)
            {
                Rear.Next = newNode;
                Rear = newNode;
                Size++; 
            }

            else
            {
                Front = newNode;
                Rear = newNode;
                Size++;
            }

        }

        /// <summary>
        /// This method removes the node from the front of the queue, and returns the node’s value. Returns exception if Queue is empty.
        /// </summary>
        /// <returns>Value of removed node</returns>
        public int Dequeue()
        {
            try
            {

                Node front = Front;
                Front = Front.Next;
                front.Next = null;
                Size--;
                return front.Value;
            }
            catch
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// This method returns the value of the node located in the front of the queue, without removing it from the queue. Returns exception if Queue is empty.
        /// </summary>
        /// <returns>value of front node</returns>
        public int Peek()
        {
            try
            {
                return Front.Value;
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
