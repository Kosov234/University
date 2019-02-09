using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_Console_
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            List<Rectangle> ListR = new List<Rectangle>();
            List<Triangle> ListT = new List<Triangle>();
            ListR.Add(new Rectangle() { x = 5, y = 5, width = 5, height = 5, color = 1 });
            ListR.Add(new Rectangle() { x = 5, y = 8, width = 3, height = 3, color = 5 });
            ListR.Add(new Rectangle() { x = 25, y = 10, width = 5, height = 4, color = 2 });
            ListR.Add(new Rectangle() { x = 15, y = 25, width = 6, height = 5, color = 3 });
            ListR.Add(new Rectangle() { x = 45, y = 45, width = 5, height = 7, color = 4 });
            ListR.Add(new Rectangle() { x = 55, y = 55, width = 9, height = 5, color = 5 });
            ListT.Add(new Triangle() { x = 25, y = 0, length = 3, color = 1 });
            ListT.Add(new Triangle() { x = 35, y = 15, length = 4, color = 2 });
            ListT.Add(new Triangle() { x = 45, y = 25, length = 5, color = 3 });
            ListT.Add(new Triangle() { x = 55, y = 35, length = 6, color = 4 });
            ListT.Add(new Triangle() { x = 65, y = 45, length = 7, color = 5 });
            ListT.Add(new Triangle() { x = 75, y = 55, length = 8, color = 6 });
            int k = 0;
            bool menu = true;
            while (k != 6)
            {
                if (menu == true)
                {
                    Console.WriteLine("1.Add Rectangle");
                    Console.WriteLine("2.Add Triangle");
                    Console.WriteLine("3.Remove Rectangle");
                    Console.WriteLine("4.Remove Triangle");
                    Console.WriteLine("5.Draw Picture");
                    Console.WriteLine("6.Finish");
                }
                int x;
                int y;
                int width;
                int height;
                int color;
                string b = Console.ReadLine();
                if (Int32.TryParse(b, out x))
                {
                    switch (x)
                    {
                        case 1:
                            Console.WriteLine("Enter x/y coordinates,width,height and color");
                            Console.WriteLine("List of available colors:");
                            Console.WriteLine("1.Red");
                            Console.WriteLine("2.Green");
                            Console.WriteLine("3.Blue");
                            Console.WriteLine("4.Magenta");
                            Console.WriteLine("5.Yellow");
                            Console.WriteLine("6.Cyan");
                            Console.WriteLine("Type x:");
                            string x1 = Console.ReadLine();
                            while (!Int32.TryParse(x1, out x) || x < 0)
                            {
                                Console.WriteLine("Type x again:");
                                x1 = Console.ReadLine();
                            }
                            Console.WriteLine("Type y:");
                            string y1 = Console.ReadLine();
                            while (!Int32.TryParse(y1, out y) || y < 0)
                            {
                                Console.WriteLine("Type y again:");
                                y1 = Console.ReadLine();
                            }
                            Console.WriteLine("Type width:");
                            string width1 = Console.ReadLine();
                            while (!Int32.TryParse(width1, out width) || width < 0)
                            {
                                Console.WriteLine("Type width again:");
                                width1 = Console.ReadLine();
                            }
                            Console.WriteLine("Type height");
                            string height1 = Console.ReadLine();
                            while (!Int32.TryParse(height1, out height) || height < 0)
                            {
                                Console.WriteLine("Type height again:");
                                height1 = Console.ReadLine();
                            }
                            Console.WriteLine("Type color:");
                            string color1 = Console.ReadLine();
                            while (!Int32.TryParse(color1, out color) || color < 0 || color > 6)
                            {
                                Console.WriteLine("Type color again:");
                                color1 = Console.ReadLine();
                            }
                            ListR.Add(new Rectangle()
                            {
                                x = x
                            ,
                                y = y
                            ,
                                width = width
                            ,
                                height = height
                                ,
                                color = color
                            });
                            Console.Clear();
                            break;
                        case 2:
                            Console.WriteLine("Enter x/y coordinates and length.");
                            Console.WriteLine("List of available colors:");
                            Console.WriteLine("1.Red");
                            Console.WriteLine("2.Green");
                            Console.WriteLine("3.Blue");
                            Console.WriteLine("4.Magenta");
                            Console.WriteLine("5.Yellow");
                            Console.WriteLine("6.Cyan");
                            int X;
                            int Y;
                            int length;
                            int COLOR;
                            Console.WriteLine("Type x:");
                            string X1 = Console.ReadLine();
                            while (!Int32.TryParse(X1, out X) || X < 0)
                            {
                                Console.WriteLine("Type x again:");
                                X1 = Console.ReadLine();
                            }
                            Console.WriteLine("Type y:");
                            string Y1 = Console.ReadLine();
                            while (!Int32.TryParse(Y1, out Y) || Y < 0)
                            {
                                Console.WriteLine("Type y again:");
                                Y1 = Console.ReadLine();
                            }
                            Console.WriteLine("Type length:");
                            string length1 = Console.ReadLine();
                            while (!Int32.TryParse(length1, out length) || length < 0)
                            {
                                Console.WriteLine("Type length again:");
                                length1 = Console.ReadLine();
                            }
                            Console.WriteLine("Type color:");
                            string COLOR1 = Console.ReadLine();
                            while (!Int32.TryParse(COLOR1, out COLOR) || COLOR > 6)
                            {
                                Console.WriteLine("Type color again:");
                                COLOR1 = Console.ReadLine();
                            }
                            ListT.Add(new Triangle()
                            {
                                x = X
                                ,
                                y = Y
                                ,
                                length = length
                                ,
                                color = COLOR
                            });
                            Console.Clear();
                            break;
                        case 3:
                            if (ListR.Count != 0 && ListR.Count != 1)
                            {
                                Console.WriteLine($"Enter the number of a rectangle:0-{ListR.Count - 1}");
                                int index = int.Parse(Console.ReadLine());
                                ListR.RemoveAt(index);
                                break;
                            }
                            if (ListR.Count == 0)
                            {
                                Console.WriteLine("No Rectangles");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Enter the number of a rectangle:{ListR.Count - 1}");
                                int index = int.Parse(Console.ReadLine());
                                ListR.RemoveAt(index);
                                break;
                            }
                        case 4:
                            if (ListT.Count != 0 && ListT.Count != 1)
                            {
                                Console.WriteLine($"Enter the number of a Triangle:0-{ListT.Count - 1}");
                                int indeks = int.Parse(Console.ReadLine());
                                ListT.RemoveAt(indeks);
                                break;
                            }
                            else
                            {
                                if (ListT.Count == 0)
                                {
                                    Console.WriteLine("No Triangles");
                                    break;
                                }
                                Console.WriteLine($"Enter the number of a Triangle:{ListT.Count - 1}");
                                int indeks = int.Parse(Console.ReadLine());
                                ListT.RemoveAt(indeks);
                                break;
                            }
                        case 5:
                            Console.Clear();
                            for (int i = 0; i < ListR.Count; i++)
                            {
                                ListR[i].DrawRectangle();
                            }
                            for (int i = 0; i < ListT.Count; i++)
                            {
                                ListT[i].DrawTriangle();
                            }
                            Console.WriteLine();
                            menu = false;
                            Console.ReadKey();
                            Console.Clear();
                            menu = true;
                            break;
                        case 6:
                            k = 6;
                            break;
                        case 7:
                            Console.WriteLine(ListR[0].y);
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Incorrect input");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect input");
                }
            }
        }
        public void Function()
        {
            Console.WriteLine("1.Add Rectangle");
            Console.WriteLine("2.Add Triangle");
            Console.WriteLine("3.Remove Rectangle");
            Console.WriteLine("4.Remove Triangle");
            Console.WriteLine("5.Draw Picture");
            Console.WriteLine("6.Finish");
        }
    }

   

    public class Rectangle
    {
        public int y { get; set; }
        public int x { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int color { get; set; }
        public void DrawRectangle()
        {
            int l = y;
            int m = x;
            for (int i = 0; i < height; i++)
            {
                
                Console.SetCursorPosition(m, l);
                switch (color)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                }
                for (int c = 0; c < width; c++)
                {
                    if (i == 0 || i == height - 1 || c == 0 || c == width - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.SetCursorPosition(m+c+1,l);
                    }
                }
                Console.ResetColor();
                l++;
            }
        }

    }
    public class Triangle
    {
        public int y { get; set; }
        public int x { get; set; }
        public int length { get; set; }
        public int color { get; set; }
        public void DrawTriangle()
        {
            int j = y;
            int m = x;
            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
            }
            for (int i = 0; i < length; i++)
            {
                Console.SetCursorPosition(m, j);
                for (int c = 0; c < length - i; c++)
                {

                    Console.SetCursorPosition(m+c+1,j);

                }
                for (int v = length - 2 * i; v <= length; v++)
                {
                    if (v == length - 2 * i || v == length || i == length - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.SetCursorPosition(m+i+v+1,j);
                    }

                }
                j++;
            }

            Console.ResetColor();
        }
    }
}
