using System;

namespace Tree.Classes
{
    public class BinaryTreeSearch
    {
        public Node Root;

        /// <summary>
        /// This method insert a method depending on the value, using recursion
        /// PairProgramming with Carrington
        /// </summary>
        public Node Add(Node root, int value)
        {
            if (root == null)
            {
                root = new Node(value);
            }
            else if (value < root.Value)
            {
                root.Left = Add(root.Left, value);
            }
            else
            {
                root.Right = Add(root.Right, value);
            }
            this.Root = root;
            return this.Root;
        }

        /// <summary>
        /// This method check if Binary contains a value using Recursion
        /// </summary>
        /// <param name="root"></param>
        public bool Contains(int value)
        {
            
            bool flag = false;
            void Helper(Node helperRoot, int checkValue)
            {
                if (!flag)
                {
                    if (helperRoot == null)
                    {
                        return;
                    }
                    if (helperRoot.Value == checkValue)
                    {
                        flag = true;
                        return;
                    }
                    if (checkValue < helperRoot.Value)
                    {
                        Helper(helperRoot.Left, checkValue);
                    }
                    else
                    {
                        Helper(helperRoot.Right, checkValue);
                    }
                }
                return;
            }

            Helper(Root, value);
            return flag;
        }

    }
}