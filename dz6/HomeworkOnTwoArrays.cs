using System;
using System.Collections.Generic;
using System.Text;

namespace dz6
{
    public static class HomeworkOnTwoArrays
    {
        public static int FindMimimalElement(int[,] array)
        {
            int minElement = array[0,0];
            for (int i = 0; i != array.GetLength(0); i++)
            {
                for (int j  = 0; j != array.GetLength(1); j++)
                {
                    if (array[i, j] < minElement)
                    {
                        minElement = array[i, j];
                    }
                }
            }
            return minElement;
        }

        public static int FindMaximalElement(int[,] array)
        {
            int maxElement = array[0,0];
            for (int i = 0; i != array.GetLength(0); i++)
            {
                for (int j  = 0; j != array.GetLength(1); j++)
                {
                    if (array[i, j] > maxElement)
                    {
                        maxElement = array[i, j];
                    }
                }
            }
            return maxElement;
        }

        public static int[] FindIndexMimimalElement(int[,] array)
        {
            int iMinimal = 0;
            int jMinimal = 0;
            int minElement = array[iMinimal, jMinimal];

            for (int i = 0; i != array.GetLength(0); i++)
            {
                for (int j = 0; j != array.GetLength(1); j++)
                {
                    if (array[i, j] < minElement)
                    {
                        iMinimal = i;
                        jMinimal = j;
                        minElement = array[iMinimal, jMinimal];
                    }
                }
            }
            int[] result = new int[] { iMinimal, jMinimal };
            return result;


        }     
        
        public static int[] FindIndexMaximalElement(int[,] array)
        {
            int iMax = 0;
            int jMax = 0;
            int MaxElement = array[iMax, jMax];

            for (int i = 0; i != array.GetLength(0); i++)
            {
                for (int j = 0; j != array.GetLength(1); j++)
                {
                    if (array[i, j] > MaxElement)
                    {
                        iMax = i;
                        jMax = j;
                        MaxElement = array[iMax, jMax];
                    }
                }
            }
            int[] result = new int[] { iMax, jMax };
            return result;
        }

        public static int CountNumberElemMoreNeighbors(int[,] array)
        {
            int count = 0;
            for(int i = 0; i<array.GetLength(0); i++)
            {
                for(int j = 0; j<array.GetLength(1); j++)
                {
                    if((i<=0 || array[i,j] > array[i-1, j])
                        && (i >= array.GetLength(0)-1 || array[i,j]>array[i+1,j])
                        && (j <= 0 || array[i, j]>array[i, j-1])
                        && (j >= array.GetLength(1)-1 || array[i,j]>array[i, j + 1]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static int[,] ReflectAnArray(int[,] array)
        {
            int[,] resultArray = new int[array.GetLength(1), array.GetLength(0)];

            for (int i = 0; i<array.GetLength(0); i++)
            {
                for(int j=0; j<array.GetLength(1); j++)
                {
                    resultArray[j, i] = array[i, j];
                }
            }
            return resultArray;
        }


    }
}
