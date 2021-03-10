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

        public static int CountTheNumnerOfOddItems(int[] array)
        {
            int j = 0;
            for(int i =0; i <array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    j += 1;
                }
            }
            return j;
        }

        public static int[] SwapFirstAndSecondHalf(int[] array)
        {
            int j = 0;
            if ((array.Length)% 2 == 1){
                for (int i = (array.Length - 1) / 2; i > 0; i--)
                {
                    int tmp = array[(array.Length) / 2 - 1 - j];
                    array[(array.Length) / 2 - 1 - j] = array[(array.Length) - 1 - j];
                    array[(array.Length) - 1 - j] = tmp;
                    j += 1;
                }
            }
            else
            {
                for (int i = (array.Length - 1) / 2; i >= 0; i--)
                {
                    int tmp = array[(array.Length) / 2 - 1 - j];
                    array[(array.Length) / 2 - 1 - j] = array[(array.Length) - 1 - j];
                    array[(array.Length) - 1 - j] = tmp;
                    j += 1;
                }
            }
            return array;
        }

        public static int[] SortSelectArray(int[] array)
        {
            for(int i = 0; i < array.Length- 1; i++)
    {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                int tmp = array[i];
                array[i] = array[min];
                array[min] = tmp;
            }
            return array;
        }

        public static int[] SortBubbleArray(int[] array)
        {
            for ( int i = 0; i!=array.Length-1; i++)
            {
                for (int j = 0; j != array.Length-1-i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
            return array;
        }

        




    }
}
