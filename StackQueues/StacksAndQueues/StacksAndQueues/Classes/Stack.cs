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

        public void Push(int value)
        {
            
            Node prevousTop = Top;
            Node newTop = new Node(value);
            Top = newTop;
            newTop.Next = prevousTop;
            Size++;

        }
    }
}
