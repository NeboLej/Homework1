using System;
using System.Collections.Generic;
using System.Text;

namespace dz6
{
    public static class HomeworkOnCycles
    {
        public static int Exponention(int a, int b)
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
            for (int i = 2; i <= b; i++)
            {
                a *= a0;

            }
            Console.WriteLine($"{a0} в степени {b} = {a}");
            return a;
        }

        public static int[] DivisionByNymber(int a)
        {
            int[] result = new int[1000 / a];
            int j = 0;
            //int a = 0;
            //a = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= 1000; i += a)
            {

                result[j] = i;
                j += 1;

                //    Console.WriteLine(i);
            }
            return result;
        }

        public static int FindTheNumberWhoseSquareIsLess(int a)
        {
            int j = 0;
            //a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; (i * i) < a; i++)
            {
                //Console.WriteLine(i);
                j +=1;
            }
            return j;
            //Console.WriteLine($"{j + 1} чисел имеют квадрат меньше числа {a}");
        }

        public static int FindTheGreatestDivision(int a)
        {
            int j = a / 2;
            for (int i = a / 2; a % i != 0; i--)
            {
                j = i - 1;
            }
            //Console.WriteLine($"Наибольший делитель числа {a} равен {j}");
            return j;
        }

        public static int FindTheSumOfNumbersDivisibleBySeven(int a, int b)
        {
            int j = 0;
            if (a == b)
            {
                throw new AggregateException("передан нулевой интервал");
            }
            else if (a > b)
            {
                for (int i = b; i <= a; i++)
                {
                    if (i % 7 == 0)
                    {
                        j += i;
                        //Console.WriteLine(i);
                    }

                }
                //Console.WriteLine($"Сумма всех чисел из интервала, кторые делятся на 7 без остатка равна {j}");
                return j;
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 7 == 0)
                    {
                        j += i;
                        //Console.WriteLine(i);
                    }

                }
                //Console.WriteLine($"Сумма всех чисел из интервала, кторые делятся на 7 без остатка равна {j}");
                return j;
            }

        }

        public static int FindTheNumberOfTheFibonacciSeries(int n)
        {
            int n0 = 0;
            int n1 = 1;
            int n2 = 1;
            for (int i = 2; i != n; i++)
            {
                n2 = n0 + n1;
                n0 = n1;
                n1 = n2;
                //Console.WriteLine(n2);

            }
            //Console.WriteLine($"{n} число ряда фибоначчи = {n2}");
            return n2;
        }

        public static int FindTheGreatestCommonFactor(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            //Console.WriteLine($"наибольший общий делитьель чисел = {a}");
            return a;
        }

        public static double FindACubeByBinaryMethod(double n)
        {
            //int i = 1;
            //Console.WriteLine("Введи положительное число, которое точно является кубом целого числа, иначе ничего не сработает");
            //n = Convert.ToDouble(Console.ReadLine());
            double b = n;
            //double n3 = (Math.Pow(n, (1 / 3)));
            //if ((n / n3) % n3 != 0)
            //{
            //    throw new ArgumentException("у переданого числе нет целого кубического корня");
            //}
            //else 
            {
                double a = 0d;
                double c = 0d;
                while ((Math.Pow(c, 3) - n) != 0d)
                {
                    c = ((a + b) / 2);
                    if ((c % 1d) != 0) //условие, которое уменьшает количество прогонов почти в 2 раза
                    {
                        c -= 0.5;
                    }

                    if ((Math.Pow(c, 3) - n) > 0d)
                    {
                        b = c;
                    }
                    else
                    {
                        a = c;
                    }
                    //Console.WriteLine($" {c} ");
                    //Console.WriteLine(i);
                    //i += 1;

                }
                return c;
                //Console.WriteLine($" {c} в кубе = {n}");
            }

        }

        public static int FindTheNumberOfOddNumbers(int a)
        {
            int i = 0;
            //Console.WriteLine("Введите число");
            //a = Convert.ToInt32(Console.ReadLine());
            int a0 = a;
            while (a0 > 0)
            {

                if (((a0 % 10) % 2) != 0)
                {
                    i += 1;
                }
                a0 /= 10;
            }
            return i;
            //Console.WriteLine($"в числе {a} есть {i} нечетных цифры");
        }

        public static int FindTheMirrorNumber(int a)
        {
            int aInvert = 0;
            //Console.WriteLine("Введите А");
            //a = Convert.ToInt32(Console.ReadLine());
            int a0 = a;
            while (a0 >= 10)
            {
                aInvert = aInvert * 10 + (a0 % 10);
                a0 /= 10;
                Console.WriteLine(aInvert);
            }
            return aInvert * 10 + a0;
            //Console.WriteLine($"Зеркальное число {aInvert * 10 + a0}");
        }

        public static int[] FindNumberrsSumOddGreaterSumEven(int n)
        {
            int nEven = 0;
            int nNotEven = 0;
            int j = 0;
            int k = 0;
            for (int i = 1; i <= n; i++)
            {
                j = i;
                nEven = 0;
                nNotEven = 0;
                if (j > 10)
                {
                    while (j / 10 > 0)
                    {
                        if ((j % 10) % 2 == 0)
                        {
                            nEven += j % 10;
                        }
                        else
                        {
                            nNotEven += j % 10;
                        }
                        j /= 10;

                    }
                }

                if ((j % 10) % 2 == 0)
                {
                    nEven += j % 10;
                }
                else
                {
                    nNotEven += j % 10;
                }

                if (nEven > nNotEven)
                {
                    k += 1;
                    //Console.WriteLine(i);
                }
            }
            nEven = 0;
            nNotEven = 0;
            j = 0;
            int[] result = new int[k];
            k = 0;
            for (int i = 1; i <= n; i++)
            {
                j = i;
                nEven = 0;
                nNotEven = 0;
                if (j > 10)
                {
                    while (j / 10 > 0)
                    {
                        if ((j % 10) % 2 == 0)
                        {
                            nEven += j % 10;
                        }
                        else
                        {
                            nNotEven += j % 10;
                        }
                        j /= 10;

                    }
                }

                if ((j % 10) % 2 == 0)
                {
                    nEven += j % 10;
                }
                else
                {
                    nNotEven += j % 10;
                }

                if (nEven > nNotEven)
                {
                    result[k] = i;
                    k += 1;
                    //Console.WriteLine(i);
                }
            }
            return result;
        }


        public static bool FindTheSameNumbers(int a, int b1)
        {
            int a0 = 0;
            int b = 0;
            int b0 = 0;
            bool rez = false;

            //Console.WriteLine("введи 2 числа");
            //a = Convert.ToInt32(Console.ReadLine());
            //b1 = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                b0 = b1;
                a0 = a % 10;
                while (b0 != 0)
                {
                    b = b0 % 10;
                    if (a0 == b)
                    {
                        rez = true;
                    }
                    b0 /= 10;
                }
                a /= 10;
            }
            if (rez)
            {
                return true;
                //Console.WriteLine("ДА");
            }
            else
            {
                return false;
                //Console.WriteLine("НЕТ");
            }
        }
    }
}
