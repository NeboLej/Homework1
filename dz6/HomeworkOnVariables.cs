using System;
using System.Collections.Generic;
using System.Text;

namespace dz6
{
    public static class HomeworkOnVariables
    {
        public static double SolutionOfAGivenEquation (double a, double b)
        {
            //Console.WriteLine("Веди A");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введи B");
            //b = Convert.ToDouble(Console.ReadLine());
            if (a == b)
            {
                throw new ArgumentOutOfRangeException("а не должен быть равен б");
            }

            double ans = 0;
            ans = (5*a+ Math.Pow(b,2))/(b-a);
            Console.WriteLine(ans);
            return ans;
        }
        public static void ChangeOfPlacesOfVariables (ref double a, ref double b)
        {
            double[] reversOrder = new double[2];

            //Console.WriteLine("Веди A");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введи B");
            //b = Convert.ToDouble(Console.ReadLine());
            double tmp = a;
            a = b;
            b = tmp;

            //reversOrder[0] = a;
            //reversOrder[1] = b;
            //Console.WriteLine($"A была {b} стала {a}, а B была {a} стала {b}");
            //return reversOrder;
        }

        public static int[] DivisionResult (int a, int b)
        {
            int[] result = new int[2] { a / b, a % b };
            //Console.WriteLine("Введи А");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введи B");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Результат деления = {(float)a / b}");
            //Console.WriteLine($"Остаток деления = {a % b}");
            return result;
        }

        public static double SolutionLinearEquation(int a, int b, int c)
        {
            //Console.WriteLine("Введи А");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введи B");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введи С");
            //c = Convert.ToInt32(Console.ReadLine());
            double x = 0d;
            x = (double)(c - b) / a;
            //Console.WriteLine($" Результат х = {x}");
            return x;
        }

        public static string DescriptionOfTheEquationPassingThroughtThePoints(int x1, int y1, int x2, int y2)
        {
            string result = "";
            // ЗАДАЧА 5
            //double x1 = 0d;
            //double x2 = 0d;
            //double y1 = 0d;
            //double y2 = 0d;

            //Console.WriteLine("Введите координаты 2 точек x1 y1 x2 y2");
            //x1 = Convert.ToDouble(Console.ReadLine());
            //y1 = Convert.ToDouble(Console.ReadLine());
            //x2 = Convert.ToDouble(Console.ReadLine());
            //y2 = Convert.ToDouble(Console.ReadLine());

            ////Находим коэфициент а
            double a = 0d;
            a = ((y2 - y1) / (x2 - x1));
            //// коэфициент b
            double b = 0d;
            b = (-x1 * (y2 - y1) / (x2 - x1) + y1);
            result = "Y = " + Convert.ToString(a) + "X + " + Convert.ToString(a);
            //Console.WriteLine($"Y = {a}X+{b}");
            return result;
        }

    }
}
