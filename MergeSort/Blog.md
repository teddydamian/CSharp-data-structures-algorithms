# Merged Sort


Create a method that takes in an array and returns a sorted array.
### PseudoCode
```
ALGORITHM Mergesort(arr)
    DECLARE n <-- arr.length
           
    if n > 1
      DECLARE mid <-- n/2
      DECLARE left <-- arr[0...mid]
      DECLARE right <-- arr[mid...n]
      // sort the left side
      Mergesort(left)
      // sort the right side
      Mergesort(right)
      // merge the sorted left and right sides together
      Merge(left, right, arr)

ALGORITHM Merge(left, right, arr)
    DECLARE i <-- 0
    DECLARE j <-- 0
    DECLARE k <-- 0

    while i < left.length && j < right.length
        if left[i] <= right[j]
            arr[k] <-- left[i]
            i <-- i + 1
        else
            arr[k] <-- right[j]
            j <-- j + 1
            
        k <-- k + 1

    if i = left.length
       set remaining entries in arr to remaining values in right
    else
       set remaining entries in arr to remaining values in left
```
| Input | Expected Output |
| :----------- | :----------- |
| [8,4,23,42,16,15]| [4,8,15,16,23,42] |
| [20,18,12,8,5,-2]  | [-2,5,8,12,18,20] |

## Steps
1. Split the array into two by determining the mid index.
2. Split the sub arrays into smaller arrays by using recursion, and stop when the array size hits 1.
3. Call another method called "Merge" that takes in the sub arrays and the original array.
4. Compare each value on the sub arrays
5. Populate new array using if statement to compare each value.
6. Return the array back to the MergeSort method, and return the array as a result of the MergeSort Method.
