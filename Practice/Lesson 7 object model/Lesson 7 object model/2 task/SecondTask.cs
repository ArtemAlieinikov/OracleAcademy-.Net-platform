using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_object_model._2_task
{
    public static class SecondTask
    {
        public static void SummArraysElements()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int a, b;

            a = GetNumber("first");
            b = GetNumber("second");

            Console.WriteLine(array[a - 1] + array[b - 1]);
        }

        private static int GetNumber(string numberOfElement)
        {
            int result;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter " + numberOfElement + " number of arrays element");
                    result = Int32.Parse(Console.ReadLine());

                    if (result <= 0 || result > 10)
                    {
                        throw new IndexOutOfRangeException("Index is incorrect");
                    }
                    else { }

                    Console.Clear();
                    break;
                }

                catch (FormatException e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }

                catch (IndexOutOfRangeException e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }
            }

            return result;
        }
    }
}
