using System;
using System.Collections.Generic;
using TableHash.Classes;
using Tree.Classes;
using Node = Tree.Classes.Node;

namespace TreeIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static List<int> TreeIntersection(BinaryTree one, BinaryTree two)
        {
            // List instead of array because we do not know how big array will be
            List<int> sameValue = new List<int>();

            // Create a hastable to store value.
            HashTable table = new HashTable(20);

            // traverse through the first tree, add its value to hashtable 
            void TraverseOne(Tree.Classes.Node root)
            {
                if (root == null)
                {
                    return;
                }
                table.Add(root.Value.ToString(), null);
                TraverseOne(root.Left);
                TraverseOne(root.Right);
            }

            // Traverse through 2nd tree and see if table contain the value from 2nd tree nodes
            void TraverseTwo(Tree.Classes.Node root)
            {
                if (root == null)
                {
                    return;
                }
                if (table.Contains(root.Value.ToString()))
                {
                    sameValue.Add(root.Value);
                }
                TraverseTwo(root.Left);
                TraverseTwo(root.Right);
            }

            TraverseOne(one.Root);
            TraverseTwo(two.Root);

            return sameValue;
        }
    }
}
