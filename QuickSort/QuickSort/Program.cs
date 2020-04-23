using System;

namespace QuickSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { 8, 4, 23, 42, 16, 15 };
            QuickSortArray(array, 0, array.Length-1);
        }

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

        static void Swap(int[] arr, int i, int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }
    }
}
