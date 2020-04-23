using System;

namespace QuickSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }

        /// <summary>
        /// This method will Sort the array by calling Partition method.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static int[] QuickSortArray(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(arr, left, right);

                QuickSortArray(arr, left, position - 1);
                QuickSortArray(arr, position + 1, right);
            }
            return arr;
        }

        /// <summary>
        /// This method will compare each value to pivot value. If it is less or equal to pivot value, it will call the method swap.
        /// Pivot is usually determined as the last value in index.
        /// It will place the pivot index in the middle of the array where left of the pivot values are less and right is greater than the pivot value.
        /// </summary>
        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];

            int low = left - 1;
            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }
            }
            Swap(arr, right, low + 1);
            return low + 1;
        }

        /// <summary>
        /// This method will swap value in an array
        /// </summary>
        static void Swap(int[] arr, int i, int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }
    }
}
