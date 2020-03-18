using System;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert length of array");

            string arrSize = Console.ReadLine();
            int arraySize = Convert.ToInt32(arrSize);

            int[] array = new int[arraySize];

            int[] arr = Populate(array);

            Console.WriteLine("Insert a number to be put inside the array");

            string num = Console.ReadLine();
            int number = Convert.ToInt32(num);

            int[] newArr = ArrayShift(arr, number);

            Console.WriteLine("Your new Array is [{0}]", string.Join(", ", newArr));
        }

        // Populating the Array
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

        static int[] ArrayShift(int[] baseArr, int number)
        {
            int[] originalArr = baseArr;
            int midIndex = originalArr.Length / 2;


            int[] newArr = new int[originalArr.Length + 1];

           
            // This will populate first half of the new array with the first half of original array
            for (int i = 0; i < midIndex; i++)
            {
                newArr[i] = originalArr[i];
            }

            // Put the number into the middle of the new Array
            newArr[midIndex] = number;

            // Repopulate all number after the mid index
            for (int i = midIndex + 1; i < newArr.Length; i++)
            {
                newArr[i] = originalArr[i - 1];
            }
            return newArr;
        }
    }
}
