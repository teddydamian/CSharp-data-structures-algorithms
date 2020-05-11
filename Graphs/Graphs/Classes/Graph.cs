using System;
using System.Collections.Generic;

namespace Graphs.Classes
{
    public class Graph<T>
    {
        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }

        public int Size { get; set; }

        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
            Size = 0;
        }

        /// <summary>
        /// Add a vertext/ node to graph
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Vertex<T> AddNode(T value)
        {
            Vertex<T> node = new Vertex<T>(value);
            AdjacencyList.Add(node, new List<Edge<T>>());
            Size++;
            return node;
        }

        /// <summary>
        /// Add an Edge to graph
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="weight"></param>
        public void AddDirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            AdjacencyList[a].Add(
                new Edge<T>
                {
                    Vertex = b,
                    Weight = weight

                }
                );
        }

        /// <summary>
        /// Add undirected edge to a graph
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="weight"></param>
        public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            AddDirectedEdge(a, b, weight);
            AddDirectedEdge(b, a, weight);
        }

        /// <summary>
        /// Get a list of all Vertices
        /// </summary>
        /// <returns></returns>
        public List<Vertex<T>> GetAllVertices()
        {
            if(Size > 0)
            {
                List<Vertex<T>> vertices = new List<Vertex<T>>();

                foreach (var vertex in AdjacencyList)
                {
                    vertices.Add(vertex.Key);
                }

                return vertices;

            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get Neighbors
        /// </summary>
        /// <param name="vertex"></param>
        /// <returns></returns>
        public List<Edge<T>> GetNeighbors(Vertex<T> vertex)
        {
            // get all edges connected to a vertex
            return AdjacencyList[vertex];
        }



        /// <summary>
        /// Print out Graphs in Console
        /// </summary>
        public void Print()
        {
            foreach (var vertex in AdjacencyList)
            {
                Console.Write($"{vertex.Key.Value}: ");

                foreach (var edge in vertex.Value)
                {
                    Console.Write($"{edge.Vertex.Value}, {edge.Weight} ->");
                }
                Console.WriteLine("null");
            }
        }


    }
}
