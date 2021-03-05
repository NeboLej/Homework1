using System;
using System.Collections.Generic;
using System.Text;

namespace dz6
{
    public static class HomeworkOnCycles
    {
        public static int Exponention (int a, int b)
        {
            //int a = 0;
            //int b = 0;
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());
            if (b == 0)
            {
                return 1;
            }
            int a0 = a;
            for (int i = 2; i<=b; i ++)
            {
                a *= a0;

            }
            Console.WriteLine($"{a0} в степени {b} = {a}");
            return a;
        }
        public static int[] DivisionByNymber (int a)
        {
            int[] result = new int[1000 / a];
            int j = 0;
            //int a = 0;
            //a = Convert.ToInt32(Console.ReadLine());
            for(int i = a; i<=1000; i += a)
            {
                j += 1;
                result[j] = i;

            //    Console.WriteLine(i);
            }
            return result;
        }

        //public static int FindTheNumberWhoseSquareIsLess(int a)
        //{
        //    // int a = 0;
        //    //a = Convert.ToInt32(Console.ReadLine());
        //    for(int i = a; i<=1000; i += a)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    return; 
        //}
    }
}
