using System;
using Xunit;
using Tree.Classes;

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
            tree.InsertNode(tree.Root, 10);
         
            Assert.Equal(10, tree.Root.Value);
        }

        /// <summary>
        /// Test to instantiate a tree with left and right Node.
        /// </summary>
        [Fact]
        public void CanAddLeftAndRightChild()
        {
            BinaryTreeSearch tree = new BinaryTreeSearch();
            tree.InsertNode(tree.Root, 10);
            tree.InsertNode(tree.Root, 15);
            tree.InsertNode(tree.Root, 5);

            Assert.Equal(5, tree.Root.Left.Value);
            Assert.Equal(15, tree.Root.Right.Value);
        }


        //[Fact]
        //public void TestForPreOrder()
        //{
        //    BinaryTreeSearch tree = new BinaryTreeSearch();
        //    tree.InsertNode(tree.Root, 10);


        //}
    }
}
