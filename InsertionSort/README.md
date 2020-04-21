# Insertion Sort

## Problem Domain
Create a method that takes in an array and return the array sorted.

### Solution
- Create a for loop that iterate the array
- Set j = 0 to stay within the loop
- Set temp = array[i]
- Set j to i-1 when i is greater than 0
- Set before = array[j]
- While temp is less than value before and value before is greater or equal to 0, set array[j]  to temp, set array[j+1] to value before, if j is less than 0, then value before is array[j-1], then J reduces by 1 on the next iteration.
- Return the array

### BigO
Space : O(n)
Time : O(n^2)
