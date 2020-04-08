using System;

namespace BreadthTraversal.Classes
{
    public class BinaryTreeSearch
    {
        public Node Root;

        /// <summary>
        /// This method insert a method depending on the value, using recursion
        /// PairProgramming with Carrington
        /// </summary>
        public Node InsertNode(Node root, int value)
        {
            if (root == null)
            {
                root = new Node(value);
            }
            else if (value < root.Value)
            {
                root.Left = InsertNode(root.Left, value);
            }
            else
            {
                root.Right = InsertNode(root.Right, value);
            }
            this.Root = root;
            return this.Root;
        }

        /// <summary>
        /// This method traverse through the BinaryTrees
        /// </summary>
        /// <param name="root"></param>
        public void Traverse(Node root)
        {
            if (root == null)
            {
                return;
            }
            Traverse(root.Left);
            Traverse(root.Right);
        }

    }
}