using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory 7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[6] { 4, 6, 2, 1, 8, 3 };
            Binary_Search(test, 6);
       
            Console.ReadKey();
        }

        public static void Bubble_Sort(int[] arr)
        {
            int SwapCounter = 0;
            int ComparCounter = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int x = 1; x < arr.Length - i; x++)
                {
                    if (arr[x - 1] > arr[x])
                    {
                        Swap(ref arr[x - 1], ref arr[x]);
                        SwapCounter++;
                        ArrDisplay(arr);
                        Console.WriteLine();
                    }
                    ComparCounter++;
                }
                ComparCounter++;
            }
            Console.WriteLine("Amount of Swaps = " + SwapCounter);
            Console.WriteLine("Amount of cmoparisons = " + ComparCounter);
        }
        public static void Selection_Sort(int[] arr)
        {
            int SwapCounter = 0;
            int ComparisonsCounter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                //ArrDisplay(arr);
                int MinIndex = FindMin(i, arr);
                int Min = arr[MinIndex];
                for (int z = MinIndex; z > i; z--)
                {
                    arr[z] = arr[z - 1];
                    SwapCounter++;
                }
                arr[i] = Min;
                ComparisonsCounter++;
                ArrDisplay(arr);
            }
            Console.WriteLine("Amount of swaps :" + SwapCounter);
            Console.WriteLine("Amount of comparisons :" + ComparisonsCounter);
        }
        public static void Swap(ref int First_Element, ref int Second_Element)
        {
            int buffer = 0;
            buffer = First_Element;
            First_Element = Second_Element;
            Second_Element = buffer;
        }
        public static void ArrDisplay(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public static int FindMin(int index, int[] arr)
        {
            int min = arr[index];
            int MinIndex = 0;
            for (int i = index; i < arr.Length; i++)
            {
                if (min >= arr[i])
                {
                    min = arr[i];
                    MinIndex = i;
                }
            }
            return MinIndex;
        }
        public static int Binary_Search(int[] arr, int value)
        {
            Selection_Sort(arr);
            int ComparCounter = 0;
            int size = arr.Length;
            int low = 0;
            int high = size - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (value == arr[mid])
                {
                    Console.WriteLine("Value " + value + " " + "Is located at index " + mid);
                    Console.WriteLine(ComparCounter + " comparisons were made");
                    return 0;
                }
                else if (value > arr[mid])
                {
                    low = mid + 1;
                    ComparCounter++;
                }
                else
                {
                    high = mid - 1;
                    ComparCounter++;
                }
            }

            return 1;
        }
        static int Factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }

            return (number * Factorial(number - 1));
        }
        static int Fibonacci(int number)
        {
            if (number == 1 || number == 2)
            {
                return 1;
            }

            return (Fibonacci(number - 1) + Fibonacci(number - 2));
        }
        static void Palindrome(string text, int left, int right)
        {
            if (left < right)
            {
                if (text[left] == text[right])
                {
                    Palindrome(text, left + 1, right - 1);
                }
                else
                    Console.WriteLine("It is not palindrome");
            }
            else
                Console.WriteLine("It is palindorme");

        }
    }
}