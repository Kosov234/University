using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaboratory2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestGCD(15, 25, 5);
            TestGCD(2, 4, 2);
            TestGCD(270, 192, 6);
            TestGCD(304, 202, 2);
            TestGCD(5, 5, 5);
            Console.ReadLine();
        }

        private static void TestGCD(int number1, int number2, int expectedResult)
        {
            var actual = GCD(number1, number2);
            var result = "\tExpected:" + expectedResult + "\tActual:" + actual;

            if (actual == expectedResult)
                result = "PASSED" + result;
            else
                result = "FAILED" + result;

            Console.WriteLine(result);
        }

        private static int GCD(int number1, int number2)
        {
            int answer = 1;
            while ((number1 != 0) || (number2 != 0))
            {
                if ((number1 > number2))
                {
                    if (number1 != 0 && number2 != 0)
                        number1 = number1 % number2;
                    else
                    {
                        break;
                    }
                }
                if (number2 > number1)
                {
                    if (number1 != 0 && number2 != 0)
                        number2 = number2 % number1;
                    else
                        break;
                }
            }
            answer = number1 + number2;
            return answer;
        }
    }
}
