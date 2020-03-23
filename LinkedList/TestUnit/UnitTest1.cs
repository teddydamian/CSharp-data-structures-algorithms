using System;
using Xunit;
using LinkedList;
using LinkedList.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// Instantiate Node and see if it has value.
        /// </summary>
        [Fact]
        public void NodeClassHasValueProperty()
        {
            // Arrange Act
            Node node = new Node();

            // Assert
            Assert.IsType<int>(node.Value);
        }

        /// <summary>
        /// Instantiate Node and get the value.
        /// </summary>
        [Fact]
        public void CanGetValueOfValuePropertyInNode()
        {
            Node node = new Node();
            node.Value = 10;

            Assert.Equal(10, node.Value);
        }

        /// <summary>
        /// Instantiate Node, set value, and get value.
        /// </summary>
        [Fact]
        public void CanChangeAndSetValueOfValuePropertyInNode()
        {
            Node node = new Node();
            node.Value = 10;
            node.Value = 15;

            Assert.Equal(15, node.Value);
        }

        /// <summary>
        /// Instantiate Node and see if it has Next property.
        /// </summary>
        [Fact]
        public void NodeClassHasNextProperty()
        {
            Node node = new Node();
            Assert.Null(node.Next);
        }

        /// <summary>
        /// Instantiate Node and and set the next property.
        /// </summary>
        [Fact]
        public void NextProperyOnNodeCanBeSet()
        {
            Node node = new Node();
            node.Value = 18;

            Node node2 = new Node();
            node.Next = node2;

            Assert.Equal(node.Next, node2);
        }

        /// <summary>
        /// Instantiate Linklist and check if it has head property.
        /// </summary>
        [Fact]
        public void LinkedListClassHasHeadProperty()
        {
            Linklist linkList = new Linklist();
            Assert.Null(linkList.Head);
        }

        /// <summary>
        /// Instantiate Linklist and set as head.
        /// </summary>
        [Fact]
        public void CanInsertNewNodeToLinkedListAsHead()
        {
            Linklist ll = new Linklist();
            ll.Insert(10);
            Assert.Equal(10, ll.Head.Value);

        }

        /// <summary>
        /// Instantiate Linklist, set a new node as head if there is a node exist.
        /// </summary>
        [Fact]
        public void CanInsertNewNodeAsHeadInLLThatAlreadyHasNodes()
        {
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);

            Assert.Equal(20, ll.Head.Value);
        }

        /// <summary>
        /// find nodes with specific value
        /// </summary>
        [Fact]
        public void CanFindNodeWithValueInLL()
        {
            // Arrange
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

            // Act
            bool exists = ll.Includes(30);

            // Assert
            // method call will be true
            Assert.True(exists);
        }

        /// <summary>
        /// See if node value isnt available in Linklist
        /// </summary>
        [Fact]
        public void CannotFindNodewithValueinLL()
        {
            // Arrange
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

            // Act
            bool exists = ll.Includes(32);

            Assert.False(exists);
        }

        /// <summary>
        /// Find head in nodes
        /// </summary>
        [Fact]
        public void CanFindHeadValueSuccessfullyInLL()
        {
            // Arrange
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

            // Act
            bool exists = ll.Includes(42);
            Assert.True(exists);

        }

        /// <summary>
        /// find last node value in the linklist
        /// </summary>
        [Fact]
        public void CanFindLastNodeValueInLL()
        {
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

            // Act
            bool exists = ll.Includes(10);
            Assert.True(exists);
        }

        /// <summary>
        /// converting linklist using new overriden method tostring
        /// </summary>
        [Fact]
        public void CanConvertLinkListToString()
        {
            // Arrange
            Linklist ll = new Linklist();
            ll.Insert(10);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(42);

            // Act 
            string allyson = ll.ToString();

            string expected = $"42 -> 30 -> 20 -> 10 -> NULL";
            // Assert
            Assert.Equal(expected, allyson);

        }
    }
}