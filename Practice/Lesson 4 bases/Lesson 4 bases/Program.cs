using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_bases
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static string SayHelloWithName(string name)
        {
            return String.Format("Hello, {0}", name);
        }

        static int GetSum(int a, int b)
        {
            return a + b;
        }

        static int InvertDigits(int number)
        {
            int grade = 1;
            int result = 0;

            if(number < 10)
            {
                result = number;
            }
            else
            {
                while(number > 0)
                {
                    result *= grade;
                    result += number % 10;
                    number /= 10;
                    grade = 10;
                }
            }

            return result;
        }

        static bool IsEven(int number)
        {
            if(number == 0)
            {
                throw new FormatException("Argument must not be zero");
            }
            else { }

            //Or, also we can write ((number & 1) != 1)
            return ((number % 2) == 0);
        }

        static void TrianglePS(double a, out double P, out double S)
        {
            P = 3 * a;
            S = a * a * Math.Sqrt(3) * 4;
        }

        static int Sum(params int[] numbers)
        {
            int result = 0;

            foreach(int number in numbers)
            {
                result += number;
            }

            return result;
        }

        static int DigitSum(int number)
        {
            int result = 0;

            if(number < 10)
            {
                return number;
            }

            result += number % 10;
            result += DigitSum(number / 10);

            return result;
        }

        static double GetMathematic(double a, double b, Mathematic operation)
        {
            double result = 0;

            switch(operation)
            {
                case Mathematic.add:
                    {
                        result = a + b;
                        break;
                    }
                case Mathematic.sub:
                    {
                        result = a - b;
                        break;
                    }
                case Mathematic.div:
                    {
                        result = a / b;
                        break;
                    }
                case Mathematic.mul:
                    {
                        result = a * b;
                        break;
                    }
            }

            return result;
        }
    }
}
