using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class Linklist
    {
        public Node Head { get; set; }
        private Node Current { get; set; }
        public int Length { get; set; }

        /// <summary>
        /// This method is used to insert a node
        /// </summary>
        /// <param name="value">The value of the node.</param>
        public void Insert(int value)
        {
            // instantiate a new Node 
            Node node = new Node();
            // set value to the inputted data
            node.Value = value;
            // set next to head
            node.Next = Head;

            //set that(new node) as the head
            Head = node;
            Length += 1;
        }

        /// <summary>
        /// This method is used to check value in nodes
        /// </summary>
        /// <param name="value">The value of the node</param>
        /// <returns>Boolean</returns>
        public bool Includes(int value)
        {
            // set c = h
            Current = Head;

            while (Current != null)
            {
                // check if value is equal
                if (Current.Value == value)
                {
                    return true;
                }

                // go to next node
                Current = Current.Next;

            }

            return false;
        }

        /// <summary>
        /// Override is to overriding built in Method in C#. In this case built-in method ToString() method is override.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            Current = Head;
            StringBuilder sb = new StringBuilder();
            while (Current != null)
            {
                sb.Append($"{Current.Value} -> ");
                Current = Current.Next;
            }

            // we are at null at this point
            sb.Append("NULL");
            return sb.ToString();
        }

        /// <summary>
        /// Method should add a new node and value before a specific node
        /// </summary>
        /// <param name="value">Target Node</param>
        /// <param name="newValue">New Node Value</param>
        public void InsertBefore(int value, int newValue)
        {
            Current = Head;
            Node current = new Node();
            current.Value = value;

            while (Current.Next.Value != value && Current.Next.Next != null)
            {
                Current = Current.Next;
            }

            if (Current.Next.Value == value)
            {
                Node nextList = Current.Next;
                Current.Next = current;
                current.Value = newValue;
                Current.Next.Next = nextList;
                Length++;
            }
            else
            {
                Console.WriteLine("cant find the note");

            }
        }

        /// <summary>
        /// Method should Check value of the nth from the end of LL. If it is bigger than LL length, it will throw exception.
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public int KthFromEnd(int k)
        {
            Current = Head;
            try
            {
                for (int i = 0; i < k-1 ; i++)
                {
                    Current = Current.Next;
                }
                return Current.Value;
            }
            catch 
            {
                throw new Exception();
            }
        }
    }
}
