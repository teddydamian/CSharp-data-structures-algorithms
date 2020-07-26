using System;
using System.Dynamic;
using System.Text;

namespace FakeBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. Return the resulting string.");
            Console.WriteLine("Test numbers are: 18376");
            string test = FakeBin("18376");
            Console.WriteLine("Press any button to continue");
            Console.ReadLine();

            Console.WriteLine($"Result: {test}");
        }

        public static string FakeBin(string x)
        {
            StringBuilder result = new StringBuilder();

            foreach (char a in x)
            {
                result.Append(a >= '5' ? '1' : '0');
            }
            return result.ToString();
        }
    }
}
