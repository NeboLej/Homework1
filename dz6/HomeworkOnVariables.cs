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
            //if (a == b)
            //{
            //    throw exception = new DivideByZeroException("dsdsfdf");
            //}

            double ans = 0;
            ans = (5*a+ Math.Pow(b,2))/(b-a);
            Console.WriteLine(ans);
            return ans;
        }
        public static void ChangeOfPlacesOfVariables (ref double a, ref double b)
        {
            double tmp = a;
            a = b;
            b = tmp;
            reversOrder[0] = a;
            reversOrder[1] = b;
            //Console.WriteLine($"A была {b} стала {a}, а B была {a} стала {b}");
            return reversOrder;
        }

        public static int[] DivisionResult (int a, int b)
        {
            int[] result = new int[2] { a / b, a % b };
            return result;
        }

        public static double SolutionLinearEquation(int a, int b, int c)
        {
            double x = 0d;
            x = (double)(c - b) / a;
            return x;
        }

        public static string DescriptionOfTheEquationPassingThroughtThePoints(int x1, int y1, int x2, int y2)
        {
            double a = 0d;
            a = ((y2 - y1) / (x2 - x1));
            double b = 0d;
            b = (-x1 * (y2 - y1) / (x2 - x1) + y1);
            string result = "";
            result = "Y = " + Convert.ToString(a) + "X + " + Convert.ToString(a);
            return result;
        }

    }
}
