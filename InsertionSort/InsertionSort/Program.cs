using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test1 = { 8, 4, 23, 42, 16, 15 };
            int[] sorted = { 20,18,12,8,5,-2};
            int[] fewUniques = {5,12,7,5,5,7};
            int[] nearlySorted = {2,3,5,7,13,11};

            Console.WriteLine("Arrays before InsertionSort");
            Console.WriteLine("[{0}]", string.Join(", ", test1));
            Console.WriteLine("[{0}]", string.Join(", ", sorted));
            Console.WriteLine("[{0}]", string.Join(", ", fewUniques));
            Console.WriteLine("[{0}]", string.Join(", ", nearlySorted));

            InsertionSort(test1);
            InsertionSort(sorted);
            InsertionSort(fewUniques);
            InsertionSort(nearlySorted);

            Console.WriteLine("Result after InsertionSort");
            Console.WriteLine("[{0}]", string.Join(", ", test1));
            Console.WriteLine("[{0}]", string.Join(", ", sorted));
            Console.WriteLine("[{0}]", string.Join(", ", fewUniques));
            Console.WriteLine("[{0}]", string.Join(", ", nearlySorted));


        }

        /// <summary>
        /// Takes in an array, returns a sorted array
        /// </summary>
        /// <param name="array">unsorted array</param>
        /// <returns>sorted array</returns>
        public static int[] InsertionSort(int[] array)
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
