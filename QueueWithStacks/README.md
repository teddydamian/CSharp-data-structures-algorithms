
# Queue with Stacks
### Author: Teddy Damian

## Problem Domain
Create a brand new PseudoQueue class. Do not use an existing Queue. Instead, this PseudoQueue class will implement our standard queue interface (the two methods listed below), but will internally only utilize 2 Stack objects. Ensure that you create your class with the following methods:
- enqueue(value) which inserts value into the PseudoQueue, using a first-in, first-out approach.
- dequeue() which extracts a value from the PseudoQueue, using a first-in, first-out approach.
The Stack instances have only push, pop, and peek methods. You should use your own Stack implementation. Instantiate these Stack objects in your PseudoQueue constructor.

Enqueue(value)
| Input | Arguments | Expected Output |
| :----------- | :----------- |:----------- |
| [10]->[15]->[20] | 5 | [5]->[10]->[15]->[20]|
|  | 5  | [5] |

Dequeue()
| Input | Output | Internal State |
| :----------- | :----------- |:----------- |
| [5]->[10]->[15]->[20] | 20 | [5]->[10]->[15]|
| [5]->[10]->[15] | 15 | [5]->[10]|

## Whiteboard Visual
![Console Output](https://github.com/teddydamian/CSharp-data-structures-algorithms/blob/master/assets/QueueWStack.png)
![WhiteBoard](https://github.com/teddydamian/CSharp-data-structures-algorithms/blob/master/assets/Enqueue.png)

## Change Log
Vers 1.0 - Created the program with the features.
