using System;

namespace dz6
{
    class Program
    {
        static void Main(string[] args)
        {
            int homeWorkNumber = 0;
            int taskNumber = 0;
            Console.WriteLine("Введи номер домашнего задания 1-4");
            homeWorkNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи номер задачи");
            taskNumber = Convert.ToInt32(Console.ReadLine());
            switch (homeWorkNumber)
            {
                case 1:
                    switch (taskNumber)
                    {
                        case 1:
                            double resultDouble = 0;
                            resultDouble = HomeworkOnVariables.SolutionOfAGivenEquation(5, 10);
                            break;
                        case 2:
                            double[] resultArray = new double[2];
                            resultArray = HomeworkOnVariables.ChangeOfPlacesOfVariables(2, 10);
                            break;
                        case 3:
                            int[] resultArray1 = new int[2];
                            resultArray1 = HomeworkOnVariables.DivisionResult(2, 10);
                            break;
                        case 4:
                            double resultDouble1 = 0;
                            resultDouble1 = HomeworkOnVariables.SolutionLinearEquation(1, 2, 3);
                            break;
                        case 5:
                            string resultString;
                            resultString = HomeworkOnVariables.DescriptionOfTheEquationPassingThroughtThePoints(1, 2, 3, 4);
                            Console.WriteLine(resultString);
                            break;



                    }

                    break;
                case 2:
                    switch (taskNumber)
                    {
                        case 1:
                            int resultInt = 0;
                            resultInt = HomeworkOnLogicalOperators.ComparingTwoNumbers(5, 10);
                            break;
                        case 2:
                            string resultString = "";
                            resultString = HomeworkOnLogicalOperators.SelectionQuarter(1, -2);
                            break;
                    }

                    break;
                case 3:
                    switch (taskNumber)
                    {
                        case 1:
                            int resultInt = 0;
                            resultInt = HomeworkOnCycles.Exponention(2, 2);
                            break;
                        case 2:
                            int a = 1;
                            int[] resultArray = new int[1000 / a];
                            resultArray = HomeworkOnCycles.DivisionByNymber(a);
                            break;
                    }

                    break;
                case 4:
                    switch (taskNumber)
                    {
                        case 1:
                            int resultInt = 0;
                            int[] array = new int[6] { 4, 8, 15, 16, 23, 42 };
                            resultInt = HomeworkOnOneArrays.FindTheMinimumElementOfAnArray(array);
                            break;
                        case 2:
                            int resultInt1 = 0;
                            int[] array1 = new int[6] { 4, 8, 15, 16, 23, 42 };
                            resultInt1 = HomeworkOnOneArrays.FindTheMaximumElementOfAnArray(array1);
                            break;
                    }

                    break;
            }
        }
    }
}
