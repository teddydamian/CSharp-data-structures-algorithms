# Quick Sort

The method QuickSort will take in an array and sort it for you by passing in the array, the first index position and the last index position.

## Pseudo
```
ALGORITHM QuickSort(arr, left, right)
    if left < right
        // Partition the array by setting the position of the pivot value 
        DEFINE position <-- Partition(arr, left, right)
        // Sort the left
        QuickSort(arr, left, position - 1)
        // Sort the right
        QuickSort(arr, position + 1, right)

ALGORITHM Partition(arr, left, right)
    // set a pivot value as a point of reference
    DEFINE pivot <-- arr[right]
    // create a variable to track the largest index of numbers lower than the defined pivot
    DEFINE low <-- left - 1
    for i <- left to right do
        if arr[i] <= pivot
            low++
            Swap(arr, i, low)

     // place the value of the pivot location in the middle.
     // all numbers smaller than the pivot are on the left, larger on the right. 
     Swap(arr, right, low + 1)
    // return the pivot index point
     return low + 1

ALGORITHM Swap(arr, i, low)
    DEFINE temp;
    temp <-- arr[i]
    arr[i] <-- arr[low]
    arr[low] <-- temp
```

## How it works
#### 1. QuickSort
The method will take in an array, the first index position and the last index position. Then with an if statement, if the first index position is less than the last index position, it will call the method partition, that takes in the parameter.

#### 2. Partition
Partition method will determine a pivot value (it is generally the last value on the index) and compare each value to pivot value with a for loop.
- If the value compared to the pivot value is less, it will call the swap method that will swap that value and the next value, placing the less on the left.
- If the value compared to the pivot value is bigger, there will be no swap.
Once the for loop is done, swap the pivot value with the number of how many swapped happen inside the for loop, which will put the the pivot value in the middle of the array. Everything on the left of pivot value in the array should be less, and everything on the right should be more than the pivot value. Keep in mind, these are just sorted according to the pivot, it is not completely sorted yet.

#### 3. Position after Partition
The method partition will return an index position of where the pivot value will be.
Using Recursion, Call the QuickSort with the array again for the left subarray and right subarray.

#### 4. Result
After all the recurrsion, all the index in the array will be compared to each of its pivot value of its array and will be separated again until it breaks out of the first if statement. (for example, the left subarray will compare each value to the pivot value(end index of left subarray), and put the pivot value in the middle of the array again.

Then QuickSort will return the sorted array.

![Visual](https://github.com/teddydamian/CSharp-data-structures-algorithms/blob/master/assets/QuickSort.png)
