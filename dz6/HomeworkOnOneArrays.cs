using System;
using System.Collections.Generic;
using System.Text;

namespace dz6
{
    public static class HomeworkOnOneArrays
    {
        public static int FindTheMinimumElementOfAnArray(int[] array)
        {
            int minElem = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minElem)
                {
                    minElem = array[i];
                }
            }
            //Console.WriteLine(minElem);
            return minElem;
        }

        public static int FindTheMaximumElementOfAnArray(int[] array)
        {
            int maxElem = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxElem)
                {
                    maxElem = array[i];
                }
            }
            //Console.WriteLine(maxElem);
            return maxElem;
        }

        public static int FindTheIndexMinimumElement(int[] array)
        {
            int minElem = array[0];
            int minIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minElem)
                {
                    minElem = array[i];
                    minIndex = i;
                }
            }
            return minIndex;
            //Console.WriteLine(minIndex);
        }

        public static int FindTheIndexMaximumElement(int[] array)
        {
            int maxElem = array[0];
            int maxIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxElem)
                {
                    maxElem = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
            //Console.WriteLine(maxIndex);
        }

        public static int CalculatingSumItemsOddIndex(int[] array)
        {
            int sumElem = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            for (int i = 1; i < array.Length; i += 2)
            {
                sumElem += array[i];
            }
            return sumElem;
            //Console.WriteLine();
            //Console.WriteLine("сумма чмсел с нечетными индексами = " + sumElem);
        }

        public static int[] ReverseArray(int[] array)
        {

            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = tmp;

            }
            return array;

        }









    }
}
