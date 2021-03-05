using System;
using System.Collections.Generic;
using System.Text;

namespace dz6
{
    public static class HomeworkOnLogicalOperators
    {
        public static int ComparingTwoNumbers (int a, int b)
        {
            //int a = 0;
            //int b = 0;
            //Console.WriteLine("Введи A B C");
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            if (a > b)
            {
                //Console.WriteLine($"A+B = {a + b}");
                result = a + b;
            }
            else if (a == b)
            {
                //Console.WriteLine($"A*B = {a * b}");
                result = a * b;
            }
            else
            {
                //Console.WriteLine($"a-b = {a - b}");
                result = a - b;
            }
            return result;
        }

        public static string SelectionQuarter (int x, int y)
        {
            //int x = 0;
            //int y = 0;
            //Console.WriteLine("Введи X и Y");
            //x = Convert.ToInt32(Console.ReadLine());
            //y = Convert.ToInt32(Console.ReadLine());
            string result = "";

            if ((x == 0) && (y == 0))
            {
                result = "олимпиадник ввел нули";
                //Console.WriteLine("олимпиадник ввел нули");
            }
            else if (x >= 0)
            {
                if (y >= 0)
                {
                    result = "I четверть";
                    //Console.WriteLine("I четверть");

                }
                else
                {
                    result = "III четверть";
                    //Console.WriteLine("III четверть");
                }
            }
            else
            {
                if (y >= 0)
                {
                    result = "II Четверть";
                    //Console.WriteLine("II Четверть");
                }
                else
                {
                    result = "IV Четверть";
                    //Console.WriteLine("IV Четверть");
                }
            }
            return result;
        }


    }
}
