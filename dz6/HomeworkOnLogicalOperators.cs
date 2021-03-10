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
                    result = "IV четверть";
                    //Console.WriteLine("III четверть");
                }
            }
            else
            {
                if (y >= 0)
                {
                    result = "II четверть";
                    //Console.WriteLine("II Четверть");
                }
                else
                {
                    result = "III четверть";
                    //Console.WriteLine("IV Четверть");
                }
            }
            return result;
        }


        public static double[] SortingThreeNumbers(double a, double b, double c)
        {
            // !!!!!!!!!!!!!!!вопрос как не дублировать ретерны а вывести рузультат в конечном 
            //int a = 0;
            //int b = 0;
            //int c = 0;
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());
            //c = Convert.ToInt32(Console.ReadLine());
            //double[] result = new double[3];
            if ((a <= b) && (a <= c))
            {

                if (b <= c)
                {
                    double[] result = new double[] { a, b, c };
                    return result;
                    //Console.WriteLine($"{a} {b} {c}");
                }
                else
                {
                    double[] result = new double[] { a, c, b };
                    return result;
                    //Console.WriteLine($"{a} {c} {b}");
                }

            }
            else if ((b <= a) && (b <= c))
            {

                if (a <= c)
                {
                    double[] result = new double[] { b, a, c };
                    return result;
                    //Console.WriteLine($"{b} {a} {c}");
                }
                else
                {

                    double[] result = new double[] { b, c, a };
                    return result;
                    //Console.WriteLine($"{b} {c} {a}");
                }

            }
            else
            {

                if (a <= b)
                {
                    double[] result = new double[] { c, a, b };
                    return result;
                    //Console.WriteLine($"{c} {a} {b}");
                }
                else
                {
                    double[] result = new double[] { c, b, a };
                    return result;
                    //Console.WriteLine($"{c} {b} {a}");
                }

            }
        }


        public static double[] SolutionQuadraticEquation(double a, double b, double c)
        {
            //ЗАДАЧА 4
            //double a = 0d;
            //double b = 0d;
            //double c = 0d;
            //Console.WriteLine("Введите A, B, C");
            //a = Convert.ToDouble(Console.ReadLine());
            //b = Convert.ToDouble(Console.ReadLine());
            //c = Convert.ToDouble(Console.ReadLine());
            double d = 0d;
            d = b * b - 4 * a * c;
            if (d < 0)
            {
                throw new ArgumentException("нет решения в вещественных числах D<0");
            }
            else
            {
                double[] result = new double[2];
                result[0] = (-b - Math.Sqrt(d)) / (2 * a);
                result[1] = (-b + Math.Sqrt(d)) / (2 * a);
                return result;
            }
        }


        public static string ConvertngNumberToAString(int a)
        {
            //int a = 0;
            //Console.WriteLine("введи 2 значное число");
            //a = Convert.ToInt32(Console.ReadLine());
            string result = "";
            if (a < 20)
            {
                switch (a)
                {
                    case 10:
                        //Console.WriteLine("Десять");
                        result = "Десять";
                        break;
                    case 11:
                        result = "Одиннадцать";
                        //Console.WriteLine("Одиннадцать");
                        break;
                    case 12:
                        result = "Двенадцать";
                        //Console.WriteLine("Двенадзать");
                        break;
                    case 13:
                        result = "Тринадцать";
                        //Console.WriteLine("Тринадцать");
                        break;
                    case 14:
                        result = "Четырнадцать";
                        //Console.WriteLine("Четырнадцать");
                        break;
                    case 15:
                        result = "Пятнадцать";
                        //Console.WriteLine("Дятнадцать");
                        break;
                    case 16:
                        result = "Шестнадцать";
                        //Console.WriteLine("Шестнадцать");
                        break;
                    case 17:
                        result = "Семнадцать";
                        //Console.WriteLine("Семнвдцать");
                        break;
                    case 18:
                        result = "Восемнадцать";
                        //Console.WriteLine("Восемнадцать");
                        break;
                    case 19:
                        result = "Девятнадцать";
                        //Console.WriteLine("Девятнадцать");
                        break;
                }
                return result;

            }
            else
            {
                int one = a / 10;
                int two = a % 10;
                string oneText = "";
                switch (one)
                {
                    case 2:
                        oneText = "Двадцать";
                        break;
                    case 3:
                        oneText = "Тридцать";
                        break;
                    case 4:
                        oneText = "Сорок";
                        break;
                    case 5:
                        oneText = "Пятьдесят";
                        break;
                    case 6:
                        oneText = "Шесдесят";
                        break;
                    case 7:
                        oneText = "Семдесят";
                        break;
                    case 8:
                        oneText = "Восемдесят";
                        break;
                    case 9:
                        oneText = "Девяносто";
                        break;
                }
                string twoText = "";
                switch (two)
                {
                    case 1:
                        twoText = "один";
                        break;
                    case 2:
                        twoText = "два";
                        break;
                    case 3:
                        twoText = "три";
                        break;
                    case 4:
                        twoText = "четыре";
                        break;
                    case 5:
                        twoText = "пять";
                        break;
                    case 6:
                        twoText = "шесть";
                        break;
                    case 7:
                        twoText = "семь";
                        break;
                    case 8:
                        twoText = "восем";
                        break;
                    case 9:
                        twoText = "девять";
                        break;
                }
                return oneText + " " + twoText;

                //Console.WriteLine($"{oneText}  {twoText}");

            }



        }



    }
}
