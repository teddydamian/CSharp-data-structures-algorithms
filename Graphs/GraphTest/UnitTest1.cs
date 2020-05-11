using System;
using Xunit;
using Graphs.Classes;
using System.Collections.Generic;

namespace GraphTest
{
    public class UnitTest1
    {

        /// <summary>
        /// Test to see if Vertex added succesfully
        /// </summary>
        [Fact]
        public void AddNewVertex()
        {
            Graph<string> graph = new Graph<string>();

            Vertex<string> vertex = new Vertex<string>("Potato");
            Assert.Equal(vertex.Value, graph.AddNode("Potato").Value);

        }

        /// <summary>
        /// Test to see if Edges added succesfully
        /// </summary>
        [Fact]
        public void AddEdges()
        {
            Graph<string> Veggies = new Graph<string>();

            var potato = Veggies.AddNode("Potato");
            var tomato = Veggies.AddNode("Tomato");
            var onion = Veggies.AddNode("Onion");

            Veggies.AddDirectedEdge(potato, tomato, 13);
            Veggies.AddDirectedEdge(potato, onion, 9);

            List<Vertex<string>> result = new List<Vertex<string>>();

            List<Edge<string>> neighbors = Veggies.GetNeighbors(potato);
            foreach (var veg in neighbors)
            {
                result.Add(veg.Vertex);
            }

            List<Vertex<string>> Expected = new List<Vertex<string>>
            {
                tomato,
                onion
            };

            Assert.Equal(Expected, result);
        }


        /// <summary>
        /// Test to get a neighbor
        /// </summary>
        [Fact]
        public void TestToGetAVertex()
        {
            Graph<string> Veggies = new Graph<string>();

            var potato = Veggies.AddNode("Potato");

            List<Vertex<string>> Expected = new List<Vertex<string>>
            {
                potato
            };

            Assert.Equal(Expected, Veggies.GetAllVertices());
        }


        /// <summary>
        /// Test for Get all Verticies
        /// </summary>
        [Fact]
        public void CanGetAllVerticies()
        {
            Graph<string> Veggies = new Graph<string>();

            var potato = Veggies.AddNode("Potato");
            var tomato = Veggies.AddNode("Tomato");
            var onion = Veggies.AddNode("Onion");

            List<Vertex<string>> Expected = new List<Vertex<string>>
            {
                potato,
                tomato,
                onion,
              
            };

            Assert.Equal(Expected, Veggies.GetAllVertices());
        }


        /// <summary>
        /// Test to Check Size of Graphs
        /// </summary>
        [Fact]
        public void TestSize()
        {
            Graph<string> Veggies = new Graph<string>();

            var potato = Veggies.AddNode("Potato");
            var tomato = Veggies.AddNode("Tomato");
            var onion = Veggies.AddNode("Onion");

            int Expected = 3;
           

            Assert.Equal(Expected, Veggies.Size);
        }

        /// <summary>
        /// Test to See if Graphs empty, return null
        /// </summary>
        [Fact]
        public void TestEmptyGraphs()
        {
            Graph<string> Veggies = new Graph<string>();

            Assert.Null(Veggies.GetAllVertices());
        }

    }
}
