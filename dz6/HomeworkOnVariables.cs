using System;
using System.Collections.Generic;
using System.Text;

namespace dz6
{
    public static class HomeworkOnVariables
    {
        public static double SolutionOfAGivenEquation (double a, double b)
        {
            if (a == b)
            {
                throw new ArgumentException("A не должен быть равен B");
            }
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
            a = ((double)(y2 - y1) / (x2 - x1));
            double b = 0d;
            b = ((double)-x1 * (double)(y2 - y1) / (x2 - x1) + y1);
            string result = "";
            result = "Y = " + Convert.ToString(a) + "X + " + Convert.ToString(b);
            Console.WriteLine(result);
            return result;
        }

    }
}
