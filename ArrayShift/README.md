# Array Shift
#### Author: Teddy Damian

## Problem Domain
Given an array of integers and a new number. Output a new array with the new number in the middle of the original array
[Click here to go to the program](https://github.com/teddydamian/CSharp-data-structures-algorithms/blob/master/ArrayShift/ArrayShift/Program.cs)

| Input | Expected Output |
| :----------- | :----------- |
| [2,2,2,2] 12 | [2,2,12,2,2] |
| [2,99,100] 12  | [2,12,99,100] |

## Whiteboard Visual
![alt text](https://github.com/teddydamian/CSharp-data-structures-algorithms/blob/master/assets/ArrayShift.png)

## Solution
- Create a new array with 1 extra room
- Split the array into half, determine the middle index
- Populate the first half of the new array with original array
- Insert the new number as the middle index of new array
- Populate the second half of the new array

## Change Log
Vers 1.0 - Created the program with the features.
