using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search");

            Console.WriteLine("Insert length of array");

            string arrSize = Console.ReadLine();
            int arraySize = Convert.ToInt32(arrSize);

            int[] array = new int[arraySize];

            int[] arr = Populate(array);

            Console.WriteLine("Insert a number to check");
            string check = Console.ReadLine();
            int checker = Convert.ToInt32(check);

            BinarySearch(array, checker);
        }

        static int[] Populate(int[] pop)
        {

            for (int i = 0; i < pop.Length; i++)
            {
                Console.WriteLine($"Enter a number, {i + 1} of {pop.Length}");

                string userInput = Console.ReadLine();
                int userInt = Convert.ToInt32(userInput);
                pop[i] = userInt;
            }
            return pop;
        }

        public static int BinarySearch(int[] inputArray, int checker)
        {
            int arraySize = inputArray.Length;
            int midIndex = arraySize / 2;


            if (inputArray[midIndex] == checker)
            {
                return midIndex;
            }

            if (inputArray[midIndex] == 0)
            {
                int value = midIndex - 1;
                return value;
            }

            if (inputArray[midIndex] > checker)
            {
                midIndex -= (midIndex / 2);
                return midIndex;
            }

            if (inputArray[midIndex] < checker && midIndex != 1)
            {
                midIndex += (midIndex / 2);
            }

            if (inputArray[midIndex] > checker && midIndex == 1)
            {
                int value = midIndex - 1;
                return value;
            }


        }
    }
}