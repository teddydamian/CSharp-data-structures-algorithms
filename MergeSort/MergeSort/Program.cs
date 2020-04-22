using System;

namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        /// <summary>
        /// This method will take in an array and sort it by separating the array into subarrays
        /// </summary>
        /// <returns>Sorted array</returns>
        public static int[] MergeSortArray(int[] array)
        {
            int n = array.Length;
            int[] result = new int[n];

            // breaks recursion when n is 1 cos cant be separated
            if (n <= 1)
            {
                return array;
            }

            if (n > 1)
            {
                int mid = n / 2;

                int[] left = new int[mid];
                int[] right = new int[n - mid];

                // populate left subarray
                for (int i = 0; i < mid; i++)
                {
                    left[i] = array[i];
                }

                // populate right subarray
                int midstart = 0;
                for (int i = mid; i < array.Length; i++)
                {
                    right[midstart] = array[i];
                    midstart++;
                }

                // recursion 
                left = MergeSortArray(left);
                right = MergeSortArray(right);

                // Merge all arrays
                result = Merge(left, right, array);
            }
            return result;
        }

        /// <summary>
        /// This method takes in 3 arrays, compare each value, and merge it.
        /// </summary>
        /// <returns>Result array</returns>
        public static int[] Merge(int[] left, int[] right, int[] array)
        {
            int i = 0; // tracker for left array
            int j = 0; // tracker for right array
            int k = 0; // tracker for result array

            int[] result = new int[array.Length];

            // loop through while counter is less than left and right array length
            while (i < left.Length || j < right.Length)
            {
                if(i < left.Length && j < right.Length)
                {
                    // populate result array after comparing each value in left[i] and right[j]
                    if(left[i] <= right[j])
                    {
                        result[k] = left[i];
                        i++;
                       
                    }
                    else
                    {
                        result[k] = right[j];
                        j++;

                    }
                    k++;
                }

                if(i < left.Length)
                {
                    result[k] = left[i];
                    i++;
                    k++;

                }
                else if(j < right.Length)
                {
                    result[k] = right[j];
                    j++;
                    k++;
                }
            }
            return array;
        }
    }
}
