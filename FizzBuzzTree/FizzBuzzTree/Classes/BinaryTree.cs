using System;
using System.Collections.Generic;
using FizzBuzzTree.Classes;

namespace FizzBuzzTree
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
        public List<string> PreOrder()
        {
            Node root = Root;
            List<string> list = new List<string>();

            void Helper(Node helper, List<string> list)
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
        public List<string> InOrder()
        {
            Node root = Root;
            List<string> list = new List<string>();

            void Helper(Node helper, List<string> list)
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
        public List<string> PostOrder()
        {
            Node root = Root;
            List<string> postOrderValues = new List<string>();
            void Helper(Node helper, List<string> list)
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
