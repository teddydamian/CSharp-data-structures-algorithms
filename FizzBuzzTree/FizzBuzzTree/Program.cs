using System;
using FizzBuzzTree.Classes;

namespace FizzBuzzTree
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        /// <summary>
        /// This method is to see the condition for FizzBuzz
        /// </summary>
        /// <param name="helperInt"></param>
        /// <returns></returns>
        static string FizzBuzzConditioning(int helperInt)
        {
            if (helperInt % 3 == 0 && helperInt % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (helperInt % 3 == 0)
            {
                return "Fizz";
            }
            else if (helperInt % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return helperInt.ToString();
            }
        }

        /// <summary>
        /// This is the method that return a fizzbuzz tree
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        public static BinaryTree FizzBuzzTreeConverter(BinaryTree tree)
        {
            Node root = tree.Root;

            void Helper(Node helper)
            {
                if (helper == null)
                {
                    return;
                }

                if (helper != null)
                {
                    helper.Value = FizzBuzzConditioning(int.Parse(helper.Value));

                    if(helper.Left != null)
                    {
                        helper.Left.Value = FizzBuzzConditioning(int.Parse(helper.Left.Value));
                    }

                    if (helper.Right != null)
                    {
                        helper.Right.Value = FizzBuzzConditioning(int.Parse(helper.Right.Value));
                    }
                }

            }
            
            Helper(root);
            return tree;
        }
    }
}
