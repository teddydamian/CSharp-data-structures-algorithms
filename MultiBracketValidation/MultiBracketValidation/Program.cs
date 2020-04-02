using System;
using System.Collections;
using System.Collections.Generic;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
        /// <summary>
        /// Method will put the closing bracket for every opening bracket.
        /// If char match with top of stack, it will from stack until its empty.
        /// If it doesnt match/dont pop from stack, it returns false.
        /// Pair programming with Sue and Brody
        /// </summary>
        /// <param name="input"></param>
        /// <returns>True/False</returns>
        public bool Validate(string input)
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
