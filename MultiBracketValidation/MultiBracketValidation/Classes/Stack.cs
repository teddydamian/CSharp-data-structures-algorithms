using System;
using System.Text;

namespace MultiBracketValidation.Classes
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
        /// Add a new Node on top of the stack with value
        /// </summary>
        /// <param name="value">Value of node</param>
        public void Push(char value)
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
        public void Pop()
        {
            try
            {
                Node oldTop = Top;
                Top = Top.Next;
                oldTop.Next = null;
                Size--;
              
            }
            catch
            {
                throw new NullReferenceException();
            }
        }

        /// <summary>
        /// Method to see if stack is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            if (Peek() == '\0')
                return true;
            return false;
        }

        /// <summary>
        /// Method to check the top node value
        /// </summary>
        /// <returns>Top node value</returns>
        public char Peek()
        {
            try
            {
                return Top.Value;
            }
            catch
            {
                return '\0';
            }
        }
        
    }
}