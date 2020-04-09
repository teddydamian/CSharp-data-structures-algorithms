using System;
using System.Collections.Generic;
using FizzBuzzTree;
using FizzBuzzTree.Classes;
using Xunit;

namespace FizzBuzzTest
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
        /// Test to see if fizzbuzz method works on a tree with only 1 node(root)
        /// </summary>
        [Theory]
        [InlineData("15", "FizzBuzz")]
        [InlineData("3", "Fizz")]
        [InlineData("5", "Buzz")]
        [InlineData("1", "1")]
        public void TestToSeeIfRootConvertedintoFizzBuzz(string testIn, string testOut)
        {
            BinaryTree inputTree = new BinaryTree();
            inputTree.Root = new Node(testIn);

            BinaryTree inputValues = Program.FizzBuzzTreeConverter(inputTree);
            List<string> input = inputValues.InOrder();

            BinaryTree expectedTree = new BinaryTree();
            expectedTree.Root = new Node(testOut);
            List<string> expected = expectedTree.InOrder();

            Assert.Equal(expected, input);
        }

        /// <summary>
        /// Test to see if fizzbuzz method works on a tree with only Left node
        /// </summary>
        [Theory]
        [InlineData("15", "3", "FizzBuzz", "Fizz")]
        [InlineData("4", "3", "4", "Fizz")]
        [InlineData("3", "30", "Fizz", "FizzBuzz")]
        [InlineData("5", "3", "Buzz", "Fizz")]
        public void TestToSeeIf2NodesConvertedintoFizzBuzzLeft(string testIn, string testIn1, string testOut, string testOut1)
        {
            BinaryTree inputTree = new BinaryTree();
            inputTree.Root = new Node(testIn);
            inputTree.Root.Left = new Node(testIn1);

            BinaryTree inputValues = Program.FizzBuzzTreeConverter(inputTree);
            List<string> input = inputValues.InOrder();

            BinaryTree expectedTree = new BinaryTree();
            expectedTree.Root = new Node(testOut);
            expectedTree.Root.Left = new Node(testOut1);
            List<string> expected = expectedTree.InOrder();

            Assert.Equal(expected, input);
        }

        /// <summary>
        /// Test to see if fizzbuzz method works on a tree with only Right node
        /// </summary>
        [Theory]
        [InlineData("20", "3", "Buzz", "Fizz")]
        [InlineData("29", "3", "29", "Fizz")]
        [InlineData("3", "60", "Fizz", "FizzBuzz")]
        [InlineData("100", "3", "Buzz", "Fizz")]
        public void TestToSeeIf2NodesConvertedintoFizzBuzzRight(string testIn, string testIn1, string testOut, string testOut1)
        {
            BinaryTree inputTree = new BinaryTree();
            inputTree.Root = new Node(testIn);
            inputTree.Root.Right = new Node(testIn1);

            BinaryTree inputValues = Program.FizzBuzzTreeConverter(inputTree);
            List<string> input = inputValues.InOrder();

            BinaryTree expectedTree = new BinaryTree();
            expectedTree.Root = new Node(testOut);
            expectedTree.Root.Right = new Node(testOut1);
            List<string> expected = expectedTree.InOrder();

            Assert.Equal(expected, input);
        }

        /// <summary>
        /// Method used to test for big fizzBuzz Tree
        /// </summary>
        [Theory]
        [InlineData("20", "3", "7", "Buzz", "Fizz", "7")]
        [InlineData("29", "3", "30", "29", "Fizz", "FizzBuzz")]
        [InlineData("3", "60", "32", "Fizz", "FizzBuzz", "32")]
        [InlineData("100", "3", "60", "Buzz", "Fizz", "FizzBuzz")]
        public void TestForABigTree(string testIn, string testIn1, string testIn2, string testOut, string testOut1, string testOut2)
        {
            BinaryTree inputTree = new BinaryTree();
            inputTree.Root = new Node(testIn);
            inputTree.Root.Right = new Node(testIn1);
            inputTree.Root.Left = new Node(testIn2);

            BinaryTree inputValues = Program.FizzBuzzTreeConverter(inputTree);
            List<string> input = inputValues.InOrder();

            BinaryTree expectedTree = new BinaryTree();
            expectedTree.Root = new Node(testOut);
            expectedTree.Root.Right = new Node(testOut1);
            expectedTree.Root.Left = new Node(testOut2);

            List<string> expected = expectedTree.InOrder();

            Assert.Equal(expected, input);
        }
    }
}
