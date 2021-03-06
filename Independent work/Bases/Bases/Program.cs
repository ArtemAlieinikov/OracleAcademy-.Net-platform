﻿using System;


namespace Bases
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[100];

            Random rnd = new Random();

            for (int i = 0; i < testArray.Length; ++i)
            {
                testArray[i] = rnd.Next(0, 300);
            }

            QuickSort(0, testArray.Length - 1, testArray);

            foreach (int i in testArray)
            {
                Console.WriteLine(i);
            }
        }

        static void QuickSort(int firstIndex, int lastIndex, int[] array)
        {
            int left = firstIndex;
            int right = lastIndex;
            int midPosotion = (firstIndex + lastIndex) / 2;

            if (left < right)
            {
                int middleElement = array[midPosotion];

                while (left < right)
                {
                    while (array[left] < middleElement)
                    {
                        ++left;
                    }

                    while (array[right] > middleElement)
                    {
                        --right;
                    }

                    if (left <= right)
                    {
                        int temp = array[left];
                        array[left] = array[right];
                        array[right] = temp;

                        ++left;
                        --right;
                    }
                }

                if (left < lastIndex)
                {
                    QuickSort(left, lastIndex, array);
                }

                if (right > firstIndex)
                {
                    QuickSort(firstIndex, right, array);
                }
            }
        }
    }
}
