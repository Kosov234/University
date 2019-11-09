using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AdolfoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Console.ReadKey();
        }

        static int NaivePower(int number, int power) //The most basic and obvious way
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int result = 1;
            for (int i = 1; i <= power; i++)
            {

                result *= number;

            }
            watch.Stop();
            var elapsedMs = watch.ElapsedTicks;
            Console.WriteLine("Execution time of Naive : " + elapsedMs + " tick(s)");
            return result;
        }

        static double IterativePower(double x, int n)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            double left = x;
            double right = 1;

            if (n < 0)
            {
                return 1 / (x * IterativePower(x, -n - 1));
            } // Avoid binary overflow!!!!

            if (n == 0)
            {
                watch.Stop();
                float elapsedMs3 = watch.ElapsedTicks;
                Console.WriteLine("Execution time of Iterative: " + elapsedMs3 + " tick(s)");
                return 1;
            }

            while (n > 1)
            {
                if (n % 2 == 1) right *= left;
                left = left * left;
                n = n / 2;
            }
            watch.Stop();
            float elapsedMs = watch.ElapsedTicks;
            Console.WriteLine("Execution time of Iterative: " + elapsedMs + " tick(s)");
            return left * right;
        }

        static int TestPower(int x,int y)
        {
            int Sum = int.Parse(Console.ReadLine());
            
            return 0;
        }

        static int RecursivePower(int x, int y)
        {
            if (y == 0)
            {
                return 1;
            }
            else if (y % 2 == 0)
                return RecursivePower(x, y / 2) * RecursivePower(x, y / 2);
            else
                return x * RecursivePower(x, y / 2) * RecursivePower(x, y / 2);
        }

        static int ModularPower(int x, int y, int p)//I'm not sure about the difference between exp4mod and exp5mod algortihms,so I wrote the universal one :)
        {
            int res = 1;
            x = x % p;
            while (y > 0)
            {
                if ((y & 1) == 1)
                    res = (res * x) % p;
                y = y / 2;
                x = (x * x) % p;
            }
            return res;
        }

        static void Exercise1()
        {
            //Exercise 1
            Console.WriteLine("Naive \n2^10 = " + NaivePower(2, 10));
            var watch = System.Diagnostics.Stopwatch.StartNew();//This mess is all about the fact that i didn't knew how to implement timer into recursive function
            var answer1 = RecursivePower(2, 10);//Sorry Mr.Adolfo :)
            watch.Stop();
            var elapsedMs = watch.ElapsedTicks;
            Console.WriteLine("Execution time of Recursive : " + elapsedMs + " tick(s)");
            Console.WriteLine("Recursive \n2^10 = " + answer1);
            Console.WriteLine("Iterative \n2^10 = " + IterativePower(2, 10));
            Console.WriteLine("Naive \n3^20 = " + NaivePower(3, 20));//?
            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            var answer2 = RecursivePower(3, 20);
            watch2.Stop();
            var elapsedTicks2 = watch2.ElapsedTicks;
            Console.WriteLine("Execution time of Recursive : " + elapsedTicks2 + " tick(s)");
            Console.WriteLine("Recursive \n3^20 = " + answer2);
            Console.WriteLine("Iterative \n3^20 = " + IterativePower(3, 20));//?
            Console.WriteLine("Naive \n5^50 = " + NaivePower(5, 50));
            var watch3 = System.Diagnostics.Stopwatch.StartNew();
            var answer3 = RecursivePower(5, 50);
            watch3.Stop();
            var elapsedTicks3 = watch3.ElapsedTicks;
            Console.WriteLine("Execution time of Recursive : " + elapsedTicks3 + " tick(s)");
            Console.WriteLine("Recursive \n5^50 = " + answer3);
            Console.WriteLine("Iterative \n5^50 = " + IterativePower(5, 50));
            Console.WriteLine("Naive \n7^121 = " + NaivePower(7, 121));
            var watch4 = System.Diagnostics.Stopwatch.StartNew();
            var answer4 = RecursivePower(7, 121);
            watch4.Stop();
            var elapsedTicks4 = watch4.ElapsedTicks;
            Console.WriteLine("Execution time of Recursive : " + elapsedTicks4 + " tick(s)");
            Console.WriteLine("Recursive \n7^121 = " + answer4);
            Console.WriteLine("Iterative \n7^121 = " + IterativePower(7, 121));

        }

        static double inv(int a, int n)
        {
            var PowerBuffer = IterativePower(a, -1);
            return PowerBuffer % n;
        }

        static void Exercise2()
        {
            Console.WriteLine("2^-1 mod 7 = " + inv(2, 7));
            Console.WriteLine("4^-1 mod 10 = " + inv(4, 10));
            Console.WriteLine("5^-1 mod 11 = " + inv(5, 11));
            Console.WriteLine("7^-1 mod 13 = " + inv(7, 13));
            Console.WriteLine("11^-1 mod 15 = " + inv(11, 15));
        }

        static int __gcd(int a, int b)
        {

            if (b == 0)
            {
                return a;
            }
            else
            {
                return __gcd(b, a % b);
            }
        }


        static int power(int x, int y, int m)
        {
            if (y == 0)
                return 1;
            int p = power(x, y / 2, m) % m;
            p = (p * p) % m;

            return (y % 2 == 0) ? p : (x * p) % m;
        }


        static void modInverse(int a, int m)
        {
            if (__gcd(a, m) != 1)
                Console.WriteLine("Inverse doesn't exist");

            else
            {
                Console.WriteLine("Modular multiplicative inverse is "
                                                + power(a, m - 2, m));
            }

        }

        static void Exercise3()
        {
            modInverse(3, 7);
            modInverse(5, 9);
            modInverse(6, 11);
            modInverse(11, 13);
            modInverse(12, 21);
        }

        static bool PrimeOrNot(int n)
        {
            var a = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }

            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", n);
                return true;
            }
            else
            {
                Console.WriteLine("{0} is not a Prime Number", n);
                return false;
            }
        }

        static void Exercise5()
        {
            bool Testp = false;
            int p = 0;
            while (Testp == false) //Reading p and checking if it is a prime number
            {
                Console.WriteLine("Enter random big prime number p");
                p = int.Parse(Console.ReadLine());
                if (PrimeOrNot(p) == true)
                {
                    Testp = true;
                }
            }
            bool Testq = false;
            int q = 0;
            while (Testq == false)//Reading q and checking if it is a prime number
            {
                Console.WriteLine("Enter random big prime number q");
                q = int.Parse(Console.ReadLine());
                if (PrimeOrNot(q) == true)
                {
                    Testq = true;
                }
            }
            bool Teste = false;
            int e = 0;
            while (Teste == false)
            {
                Console.WriteLine("Enter natural e such that e and ({0}-1)({1}-1) were coprime", p, q);
                e = int.Parse(Console.ReadLine());
                if (__gcd((p - 1) * (q - 1), e) == 1)
                {
                    Teste = true;
                }
            }
            double d = 0;
            bool Testd = false;
            while (Testd == false)
            {
                Console.WriteLine("Enter such d that d * {0} = 1 mod ({1}-1)({2}-1)", e, p, q);
                d = double.Parse(Console.ReadLine());
                if (d * e == 1 % ((p - 1) * (q - 1)))
                {
                    Testd = true;
                }
            }
            int n = p * q;
            Console.WriteLine("Pair ({0},{1}) is your public key", n, e);
            Console.WriteLine("Pair ({0},{1}) is your private key", n, d);
        }
    }
}

