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

        /// <summary>
        /// Method will put the closing bracket for every opening bracket.
        /// If char match with top of stack, it will from stack until its empty.
        /// If it doesnt match/dont pop from stack, it returns false.
        /// Pair programming with Sue and Brody
        /// </summary>
        /// <param name="input"></param>
        /// <returns>True/False</returns>
        public static bool MultiBracketValidation(string input)
        {
            Stack stax = new Stack();

            foreach (char x in input)
            {
                if (x == '(')
                {
                    stax.Push(')');
                }
                else if (x == '[')
                {
                    stax.Push(']');
                }
                else if (x == '{')
                {
                    stax.Push('}');
                }
                else if (x == stax.Peek())
                {
                    stax.Pop();
                }
                else if (x == ')' || x == ']' || x == '}')
                {
                    return false;
                }
            }

            if (stax.IsEmpty())
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}