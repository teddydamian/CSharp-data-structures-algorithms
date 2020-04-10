using System;
using TreeCompare;
using TreeCompare.Classes;
using Xunit;

namespace CompareTesting
{
    public class UnitTest1
    {
        /// <summary>
        /// Test to see if Compare method works
        /// </summary>
        [Fact]
        public void TestForTrueBool()
        {
            BinaryTree tree1 = new BinaryTree();
            tree1.Root = new Node(2345);
            tree1.Root.Left = new Node(2345);
            tree1.Root.Right = new Node(456);

            BinaryTree tree2 = new BinaryTree();
            tree2.Root = new Node(346);
            tree2.Root.Left = new Node(3245);
            tree2.Root.Right = new Node(6543);

            bool result = Program.CompareTrees(tree1, tree2);
            Assert.True(result);
        }


        /// <summary>
        /// Test to see if Bigger trees comparable
        /// </summary>
        [Fact]
        public void TestForBiggerTree()
        {
            BinaryTree tree1 = new BinaryTree();
            tree1.Root = new Node(123);
            tree1.Root.Left = new Node(1);
            tree1.Root.Right = new Node(1234);
            tree1.Root.Left.Left = new Node(23);
            tree1.Root.Left.Right = new Node(345);

            BinaryTree tree2 = new BinaryTree();
            tree2.Root = new Node(2345);
            tree2.Root.Left = new Node(5645);
            tree2.Root.Right = new Node(456);
            tree2.Root.Left.Left = new Node(5467);
            tree2.Root.Left.Right = new Node(562354);

            bool result = Program.CompareTrees(tree1, tree2);
            Assert.True(result);
        }

        /// <summary>
        /// Test to see if different tree return false
        /// </summary>
        [Fact]
        public void TestForFalse()
        {
            BinaryTree tree1 = new BinaryTree();
            tree1.Root = new Node(123);
            tree1.Root.Left = new Node(1);
            tree1.Root.Right = new Node(1234);
            tree1.Root.Left.Left = new Node(23);
            tree1.Root.Left.Right = new Node(345);

            BinaryTree tree2 = new BinaryTree();
            tree2.Root = new Node(2345);
            tree2.Root.Left = new Node(5645);
            tree2.Root.Right = new Node(456);
            tree2.Root.Left.Left = new Node(5467);
            tree2.Root.Left.Right = new Node(562354);
            tree2.Root.Right.Right = new Node(123);
            tree2.Root.Right.Left = new Node(2345);

            bool result = Program.CompareTrees(tree1, tree2);
            Assert.False(result);
        }

        /// <summary>
        /// Test to see if smaller tree return false
        /// </summary>
        [Fact]
        public void TestForFalseWithSmallTrees()
        {
            BinaryTree tree1 = new BinaryTree();

            BinaryTree tree2 = new BinaryTree();
            tree2.Root = new Node(2345);
            tree2.Root.Left = new Node(5645);

            bool result = Program.CompareTrees(tree1, tree2);
            Assert.False(result);
        }

        /// <summary>
        /// Test to see 2 empty tree return True
        /// </summary>
        [Fact]
        public void TestFor2TreesWithOnlyRoot()
        {
            BinaryTree tree1 = new BinaryTree();
            BinaryTree tree2 = new BinaryTree();

            bool result = Program.CompareTrees(tree1, tree2);
            Assert.True(result);
        }
    }
}
