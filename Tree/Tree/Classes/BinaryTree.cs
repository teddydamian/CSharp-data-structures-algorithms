using System;
using System.Collections.Generic;

namespace Tree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        /// <summary>
        /// This method will return a list of int from PreOrder
        /// PairProgramming with Carrington
        /// </summary>
        /// <returns></returns>
        public List<int> PreOrder()
        {
            Node root = Root;
            List<int> list = new List<int>();     

            void Helper(Node helper, List<int> list)
            {
                if (helper == null)
                {
                    return;
                }

                list.Add(helper.Value);
                Helper(helper.Left, list);
                Helper(helper.Right, list);
            }
            Helper(root, list);
            return list;
        }


        /// <summary>
        /// This method will return a list of int from InOrder
        /// PairProgramming with Carrington
        /// </summary>
        /// <returns></returns>
        public List<int> InOrder()
        {
            Node root = Root;
            List<int> list = new List<int>();

            void Helper(Node helper, List<int> list)
            {
                if (helper == null)
                {
                    return;
                }

                Helper(helper.Left, list);
                list.Add(helper.Value);
                Helper(helper.Right, list);
            }

            Helper(root, list);
            return list;
        }

        /// <summary>
        /// This method will return a list of int from PostOrder
        /// PairProgramming with Carrington
        /// </summary>
        /// <returns></returns>
        public List<int> PostOrder()
        {
            Node root = Root;
            List<int> postOrderValues = new List<int>();
            void Helper(Node helper, List<int> list)
            {
                if (helper == null)
                {
                    return;
                }

                Helper(helper.Left, list);
                Helper(helper.Right, list);
                list.Add(helper.Value);

            }

            Helper(root, postOrderValues);
            return postOrderValues;
        }

    }
}
