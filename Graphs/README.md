# Graphs Implementation
A Graph is a non-linear data structure consisting of nodes and edges. The nodes are sometimes also referred to as vertices and the edges are lines or arcs that connect any two nodes in the graph. 

## Features
#### AddNode()
Adds a new node to the graph
Takes in the value of that node
Returns the added node
#### AddEdge()
Adds a new edge between two nodes in the graph
Include the ability to have a “weight”
Takes in the two nodes to be connected by the edge
Both nodes should already be in the Graph
#### GetNodes()
Returns all of the nodes in the graph as a collection (set, list, or similar)
#### GetNeighbors()
Returns a collection of edges connected to the given node
Takes in a given node
Include the weight of the connection in the returned collection
#### Size()
Returns the total number of nodes in the graph

## Data Structure Time Complexity
|Storage   | Add Vertex.     | Add Edge     | Remove Vertex| Remove Edge |Query|
|----------|:----------------|:-------------|:-------------|:------------|:---:|
| O(\|V\|+\|E\|)  | O(1)         |O(1)          | O(\|V\| + \|E\|) | O(\|E\|)      |O(\|V\|)|

Source geeksforgeeks.com
