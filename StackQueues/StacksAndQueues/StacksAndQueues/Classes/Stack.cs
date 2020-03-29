using System;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        private Node Top { get; set; }

        public int Size { get; set; } = 0;

        public Stack()
        {
            Top = null;
        }

        /// <summary>
        /// Override is to overriding built in Method in C#. In this case built-in method ToString() method is override.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            Node current = Top;
            StringBuilder sb = new StringBuilder();

            // Top of stack
            sb.Append("Top of Stack -> ");

            // Middle of stack
            while (current != null)
            {
                sb.Append($"{current.Value} -> ");
                current = current.Next;
                
            }
            
            // End of stack
            sb.Append("NULL");
            return sb.ToString();
        }

        /// <summary>
        /// Add a new Node on top of the stack with value
        /// </summary>
        /// <param name="value">Value of node</param>
        public void Push(int value)
        {  
            Node prevousTop = Top;
            Node newTop = new Node(value);
            Top = newTop;
            newTop.Next = prevousTop;
            Size++;
        }

        /// <summary>
        /// Remove Top Nodes and return its value.
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            try
            {
                Node oldTop = Top;
                Top = Top.Next;
                oldTop.Next = null;
                Size--;
                return oldTop.Value;
            }
            catch(NullReferenceException e)
            {
                throw e;
            }
        }

        //Define a method called peek that does not take an argument and returns the value of the node located on top of the stack,
        //without removing it from the stack.
//Should raise exception when called on empty stack
        public int Peek()
        {
            try
            {
                return Top.Value;
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
