using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search");

            int[] array = { 2, 4, 8, 15, 16, 23, 42 , 84 };
       
            int checker = 4;
            int checker1 = 8;
            int checker2 = 15;
            int checker3 = 16;
            int checker4 = 23;
            int checker5 = 42;
         
            int result = BinarySearch(array, checker);
            int result1 = BinarySearch(array, checker1);
            int result2 = BinarySearch(array, checker2);
            int result3 = BinarySearch(array, checker3);
            int result4 = BinarySearch(array, checker4);
            int result5 = BinarySearch(array, checker5);

            Console.WriteLine($"{checker} is at index {result}");
            Console.WriteLine($"{checker1} is at index {result1}");
            Console.WriteLine($"{checker2} is at index {result2}");
            Console.WriteLine($"{checker3} is at index {result3}");
            Console.WriteLine($"{checker4} is at index {result4}");
            Console.WriteLine($"{checker5} is at index {result5}");

        }
        /// <summary>
        /// This method will do the search, move to left if its less than mid index, move to right when its more than mid index, and check until mid Index is same with checker.
        /// </summary>
        /// <param name="inputArray">Given Array.</param>
        /// <param name="checker">Number that is given to check.</param>
        /// <returns>Either return index number or -1 if not found.</returns>
        public static int BinarySearch(int[] inputArray, int checker)
        {
            int arraySize = inputArray.Length;
           

            bool flag = false;
            int midIndex = arraySize / 2;

            while (midIndex <= arraySize )
            {
                if (inputArray[midIndex] == checker)
                {
                    flag = true;
                    break;
                }

                if (midIndex == 0)
                {
                    break;
                }

                if (midIndex == arraySize - 1)
                {
                    break;
                }

                if (inputArray[midIndex] > checker)
                {
                    midIndex -= 1;
                }

                if (inputArray[midIndex] < checker && midIndex != 1 )
                {
                    midIndex += 1;

                }
                if (inputArray[midIndex] > checker && midIndex == 1)
                {
                    midIndex -= 1;
                }
            }

            if (flag == true)
            {
                
                return midIndex;
            }
            else
            {
                return -1;
            }
       
        }
    }
}