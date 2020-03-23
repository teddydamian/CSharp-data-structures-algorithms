using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class Linklist
    {
        public Node Head { get; set; }
        private Node Current { get; set; }


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


    }
}