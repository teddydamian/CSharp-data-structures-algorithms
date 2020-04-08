using System;
using System.Collections.Generic;
using BreadthTraversal.Classes;

namespace BreadthTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public List<int> BreadthFirstTraversal(BinaryTree tree)
        {
            if(tree.Root.Value != null)
            {
                List<int> x = new List<int>();
                x.Add(tree.Root.Value);

                if(tree.Root.Left.Value == null)
                {

                    if(tree.Root.Right.Value == null)
                    {
                        return x;
                    }
                }
                else
                {

                    x.Add(tree.Root.Left.Value);
                    x.Add(tree.Root.Right.Value);
                }


            }
            else
            {
                List<int> x = new List<int>();
                return x;
            }
        }
    }
}
