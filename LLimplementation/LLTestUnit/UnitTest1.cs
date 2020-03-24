using System;
using Xunit;
using LLimplementation.Classes;

namespace LLTestUnit
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

    }
}

