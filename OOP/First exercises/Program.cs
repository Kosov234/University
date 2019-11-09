using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //firstTask();
            //secondTask();
            //thirdTask();
            //fourthTask();
            fifthTask();
        }
        
        public static void firstTask()
        {
            var userNumbers = GetNumbers(5);

            PrintEvenNumbers(userNumbers);
        }

        private static void PrintEvenNumbers(int[] userNumbers)
        {
            Console.WriteLine("Even numbers found:");
            for (int counter = 0; counter < userNumbers.Length; counter++)
            {
                if (userNumbers[counter] % 2 == 0)
                {
                    Console.WriteLine(userNumbers[counter]);
                }
            }
        }

        public static int[] GetNumbers(int size)
        {
            int[] numbers = new int[size];
            Console.WriteLine("Enter your numbers:");
            for (int counter = 0; counter < numbers.Length; counter++)
            {
                numbers[counter] = int.Parse(Console.ReadLine());
            }
            return numbers;
        }
        public static void showArray(int[] array)
        {
            Console.WriteLine("Numbers:");
            for (int counter = 0; counter < array.Length; counter++)
            {
                Console.WriteLine(array[counter]);
            }
        }
        public static void secondTask()
        {
            var numbers = GetNumbers(7);
            Console.WriteLine("Numbers: ");
            for (int counter = 0; counter < numbers.Length; counter++)
            {
                if (counter != 1)
                {
                    Console.WriteLine(numbers[counter]);
                }
            }
        }
        public static void thirdTask()
        {
            var numbers = GetNumbers(7);

            showArray(numbers.Take(5).ToArray());
        }
        public static void fourthTask()
        {
            var numbers = GetNumbers(7);

            numbers.Reverse().ToArray();

            Console.WriteLine("Numbers:");
            showArray(numbers);
        }
        public static void fifthTask()
        {
            var numbers = GetNumbers(7);

            Array.Sort(numbers);
            showArray(numbers);
        }
    }
}
