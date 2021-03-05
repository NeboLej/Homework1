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




    }
}
