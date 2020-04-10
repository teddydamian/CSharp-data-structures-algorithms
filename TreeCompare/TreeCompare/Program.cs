using System;
using TreeCompare.Classes;

namespace TreeCompare
{
    public class Program
    {
        static void Main(string[] args)
        {


        }

        /// <summary>
        /// This Method compares 2 trees, return a bool depending on the size of the trees
        /// </summary>
        /// <param name="treeOne"></param>
        /// <param name="treeTwo"></param>
        /// <returns></returns>
        public static bool CompareTrees(BinaryTree treeOne, BinaryTree treeTwo)
        {
            Node root1 = treeOne.Root;
            Node root2 = treeTwo.Root;
            int counter = 0;

            if (root1 == null && root2 == null)
            {
                return true;
            }

            if (root1 == null || root2 == null)
            {
                return false;
            }

            int Counter(Node root)
            {
                if (root == null)
                {
                    return counter;
                }

                if (root.Left == null && root.Right == null)
                {
                    counter++;
                }
                Counter(root.Left);
                Counter(root.Right);
                return counter;
            }

            treeOne.NumOfFiles = Counter(root1);
            counter = 0;
            treeTwo.NumOfFiles = Counter(root2);

            if (treeOne.NumOfFiles == treeTwo.NumOfFiles)
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
