using System;

namespace dz6
{
    class Program
    {
        static void Main(string[] args)
        {
            //int result = 0;
            //int[,] array = new int[,] { { 3, 5, 7 }, { 8, -3, -9 }, { 0, 18, 90 } };
            //result = HomeworkOnTwoArrays.FindMimimalElement(array);
            //Console.WriteLine(result);

            //int result = 0;
            //int[,] array = new int[,] { { 3, 5, 700 }, { 8, -3, -9 }, { 0, 18, 90 } };
            //result = HomeworkOnTwoArrays.FindMaximalElement(array);
            //Console.WriteLine(result);


            //int[] result = new int[2];
            //int[,] array = new int[,] { { 3, 5, -700 }, { 8, -3, -9 }, { 0, 18, 90 } };
            //result = HomeworkOnTwoArrays.FindIndexMimimalElement(array);
            //Console.WriteLine(result[0]);
            //Console.WriteLine(result[1]);


            //int[] result = new int[2];
            //int[,] array = new int[,] { { 3, 5, 700 }, { 8, -3, -9 }, { 0, 18, 90 } };
            //result = HomeworkOnTwoArrays.FindIndexMaximalElement(array);
            //Console.WriteLine(result[0]);
            //Console.WriteLine(result[1]);


            //int result = 0;
            //int[,] array = new int[,] { { 3, 5, 700 }, { 8, 9, -9 }, { 0, 18, 90 } };
            //result = HomeworkOnTwoArrays.CountNumberElemMoreNeighbors(array);
            //Console.WriteLine(result); 
            
            int[,] array = new int[,] { { 3, 5, 700 }, { 8, 9, -9 }, { 0, 18, 90 } };
            int[,] resultArray = new int[array.GetLength(1), array.GetLength(0)];
            resultArray = HomeworkOnTwoArrays.ReflectAnArray(array);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{ array[i, j]} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < resultArray.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < resultArray.GetLength(1); j++)
                {
                    Console.Write($"{ resultArray[i, j]} ");
                }
            }


        }
    }
}
