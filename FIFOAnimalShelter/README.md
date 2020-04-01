
# Queue with Stacks
### Author: Teddy Damian

## Problem Domain
Create a class called AnimalShelter which holds only dogs and cats. The shelter operates using a first-in, first-out approach.
Implement the following methods:
- enqueue(animal): adds animal to the shelter. animal can be either a dog or a cat object.
- dequeue(pref): returns either a dog or a cat. If pref is not "dog" or "cat" then return null.

Enqueue(animal)
| Input | Arguments | Expected Output |
| :----------- | :----------- |:----------- |
| Dog -> Cat -> Dog | Dog1 | Dog1 -> Dog -> Cat -> Dog|


Dequeue(pref)
| Input |  Output |
| :----------- | :----------- |
|  Dog1 -> Dog -> Cat -> Dog |  Dog1 -> Dog -> Cat   |


## Whiteboard Visual
![WhiteBoard](https://github.com/teddydamian/CSharp-data-structures-algorithms/blob/master/assets/FIFO.png)


## Change Log
Vers 1.0 - Created the program with the features.
