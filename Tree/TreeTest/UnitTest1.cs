using System;
using Xunit;
using Tree.Classes;
using System.Collections.Generic;

namespace TreeTest
{
    public class UnitTest1
    {

        /// <summary>
        /// Test for instantiating a new Tree
        /// </summary>
        [Fact]
        public void InstantiateANewTree()
        {
            BinaryTree tree = new BinaryTree();
            Assert.Null(tree.Root);
        }

        /// <summary>
        /// Test to instantiate a tree with a root
        /// </summary>
        [Fact]
        public void InstantiateANewTreeWithARootNode()
        {
            BinaryTreeSearch tree = new BinaryTreeSearch();
            tree.Add(tree.Root, 10);
         
            Assert.Equal(10, tree.Root.Value);
        }

        /// <summary>
        /// Test to instantiate a tree with left and right Node.
        /// </summary>
        [Fact]
        public void CanAddLeftAndRightChild()
        {
            BinaryTreeSearch tree = new BinaryTreeSearch();
            tree.Add(tree.Root, 10);
            tree.Add(tree.Root, 15);
            tree.Add(tree.Root, 5);

            Assert.Equal(5, tree.Root.Left.Value);
            Assert.Equal(15, tree.Root.Right.Value);
        }

        /// <summary>
        /// Testing for PreOrder
        /// </summary>
        [Fact]
        public void TestingPreOrder()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(30);
            tree.Root.Left = new Node(35);
            tree.Root.Right = new Node(25);
            tree.Root.Left.Right = new Node(20);

            List<int> expected = new List<int> { 30, 35, 20, 25 };

            Assert.Equal(expected, tree.PreOrder());
        }

        /// <summary>
        /// Testing for Post Order
        /// </summary>
        [Fact]
        public void TestingPostOrder()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(30);
            tree.Root.Left = new Node(35);
            tree.Root.Right = new Node(25);
            tree.Root.Left.Right = new Node(20);

            List<int> expected = new List<int> { 20, 35, 25, 30 };

            Assert.Equal(expected, tree.PostOrder());
        }

        /// <summary>
        /// Testing for Post Order
        /// </summary>
        [Fact]
        public void TestingInOrder()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(30);
            tree.Root.Left = new Node(35);
            tree.Root.Right = new Node(25);
            tree.Root.Left.Right = new Node(20);

            List<int> expected = new List<int> { 35, 20, 30, 25 };

            Assert.Equal(expected, tree.InOrder());
        }
    }
}
