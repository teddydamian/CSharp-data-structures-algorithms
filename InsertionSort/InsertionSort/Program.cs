using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Takes in an array, returns a sorted array
        /// </summary>
        /// <param name="array">unsorted array</param>
        /// <returns>sorted array</returns>
        public int[] InsertionSort(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                int j = 0;
                int temp = array[i];

                if (i > 0)
                {
                    j = i - 1;
                };
              
                int before = array[j];

                while (temp < before && j >= 0)
                {
                    array[j] = temp;
                    array[j + 1] = before;

                    if (j > 0)
                    {
                        before = array[j - 1];
                    }
                    j = j - 1;
                }
            }
            return array;
        }
    }
}
