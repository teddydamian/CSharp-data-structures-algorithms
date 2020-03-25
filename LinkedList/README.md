# Singly LinkedList
### Author: Teddy Damian
## Problem Domain 1:
#### How to Create LinkedList using C# - TTD.
- Creating Nodes
- Setting Value
- Inserting Nodes
- Setting Value to head
- Checking the next value on node
- Overriding the built-in method ToString()
### API
| Input | Expected Output |
| :----------- | :----------- |
| Insert() | add new node and assign value to Head.|
| Include() | Return true or False if there is value in node.|
| ToString() | Outputing the Linkedlist as a string.|

![WB](https://github.com/teddydamian/CSharp-data-structures-algorithms/blob/master/assets/New2.png)

## Problem Domain 2:
#### Create a method called InsertBefore that takes in 2 arguments (newValue and value) to add a new node in a linkedList before a specific node.
#### O(1) 
### API
| Input | Expected Output |
| :----------- | :----------- |
| [1,2,3,4] 5 | [1,2,5,3,4] | 
| [2,99,100] 12  | [2,12,99,100] |
InsertBefore(newValue, value)
newValue = the new value going to be added.
value = the value of the next node value.

[Link to Code](https://github.com/teddydamian/CSharp-data-structures-algorithms/blob/master/LinkedList/LinkedList/Classes/LinkedList.cs)
![WB](https://github.com/teddydamian/CSharp-data-structures-algorithms/blob/master/assets/kth.png)

## Change Log
- Vers 1.0 - Created the program with the features.
- Vers 2.0 - Created a method called InsertBefore.
- Vers 3.0 - Created a method called KthFromEnd.
