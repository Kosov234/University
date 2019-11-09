using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_second_class
{
    class Program
    {
        static void Main(string[] args)
        {
            firstTask();
        }

        public static void firstTask()
        {
            while (true)
            {
                colours userInput = drawMenuAndAskForInput();
                switch (userInput)
                {
                    case colours.Black:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        break;
                    case colours.White:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Not supported");
                        break;

                }

            }
        }

        public static colours drawMenuAndAskForInput()
        {
            Console.WriteLine("Choose a colour for the background");
            Console.WriteLine(colours.Black + ": " + (int)colours.Black);
            Console.WriteLine(colours.White + ": " + (int)colours.White);
            Console.WriteLine(colours.Red + ": " + (int)colours.Red);
            Console.WriteLine(colours.Blue + ": " + (int)colours.Blue);
            Console.WriteLine(colours.Yellow + ": " + (int)colours.Yellow);
            return (colours)Enum.Parse(typeof(colours),Console.ReadLine());
        }

        public enum colours
        {
            Black = 1,
            White,
            Red,
            Blue,
            Yellow

        }   

        public static void secondTask()
        {
            Console.WriteLine("Insert a sentence");

            string sentence = Console.ReadLine();
            Console.WriteLine("Number of words: " + sentence.Split(' ').Length);

            string[] words = sentence.Split(' ');
            for (int counter = 0; counter < words.Length; counter++)
            {
                if (counter % 2 != 0)
                {
                    Console.WriteLine(words[counter].ToLower());
                }
                else
                {
                    Console.WriteLine(words[counter].ToUpper());
                }
            }
        }

        public static void thirdTask()
        {
            Console.WriteLine("Insert a sentence");
            string sentence = Console.ReadLine();

            sentence = sentence
                .TrimStart('!','-','/')
                .Substring(0,20)
                .Replace('a', 'A')
                .Replace('e', 'E')
                .Replace('i', 'I')
                .Replace('o', 'O')
                .Replace('u', 'U');

            Console.WriteLine(sentence);
        }

        public static void fourthTask()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Insert first int to divide");
                    int firstInt = int.Parse(Console.ReadLine());

                    Console.WriteLine("Insert second int to divide");
                    int secondInt = int.Parse(Console.ReadLine());

                    var result = firstInt / secondInt;
                    Console.WriteLine(result);
                    
                }
                catch(FormatException)
                {
                    Console.WriteLine("Numbers have to be integers!");
                }
                catch(DivideByZeroException)
                {
                    Console.WriteLine("It's not possible to divide by 0!");
                }
            }
        }
    }
}
