using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Final(10);
            Final(100);
            Final(10000);
            Final(10000000)
        }

        public static int[] Generate(int size)
        {
            Random rnd = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(1, 100);
            }
            return array;
        }
        public static void FindMin(int[] arr)
        {
            int ComparCounter = 0;
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min>arr[i])
                {
                    min = arr[i];
                }
                ComparCounter++;
            }
            Console.WriteLine("The least value: "+min);
            Console.WriteLine("Amount of comparisons "+ComparCounter);
        }
        public static void ShowArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static void FindInt(int number,int[] arr)
        {
            int ComparCounter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                ComparCounter++;
                if (number == arr[i])
                {
                    Console.WriteLine("Your number has index "+i);
                    Console.WriteLine("Number of comparisons "+ComparCounter);
                    return;
                }
            }
            Console.WriteLine("Integer " + number + " is not found");
        }
        static void QuickSort(int[] arr)
        {
            int temp;
            int ComparCounter = 0;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        ComparCounter++;
                    }
                }
            }
            Console.WriteLine("Number of swaps: " + ComparCounter);


        }
        static void Final(int size)
        {
            int[]test = Generate(size);
            ShowArr(test);
            FindMin(test);
            QuickSort(test);
            ShowArr(test);
            FindInt(1, test);
        }

    }
}
