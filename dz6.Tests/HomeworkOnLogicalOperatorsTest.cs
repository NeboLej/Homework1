using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace dz6.Tests
{
    class HomeworkOnLogicalOperatorsTest
    {
        [TestCase(5, 4, 9)]
        [TestCase(2, 2, 4)]
        [TestCase(60, 70, -10)]
        public void LogicalOperatortsTest1(int a, int b, int expected)
        {
            int actual = HomeworkOnLogicalOperators.ComparingTwoNumbers(a, b);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1, 1, "I четверть")]
        [TestCase(1, -11, "IV четверть")]
        [TestCase(-1, -11, "III четверть")]
        [TestCase(-71, 1, "II четверть")]
        public void LogicalOperatorsTest2(int x, int y, string expected)
        {
            string actual = HomeworkOnLogicalOperators.SelectionQuarter(x, y);
            Assert.AreEqual(expected, actual);
        }

        
        [TestCase(10 , 7, -2, new double[] {-2, 7, 10})]
        [TestCase(1 , 7, -10, new double[] {-10, 1, 7})]
        [TestCase(-1 , 7, 10, new double[] {-1, 7, 10})]
        public void LogicalOperatorsTest3(double a , double b, double c, double[] expected)
        {
            double[] actual = HomeworkOnLogicalOperators.SortingThreeNumbers(a, b, c);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(5, 6 ,1, new double[] { -1, - 0.2})]
        [TestCase(-1, 4 ,0, new double[] { 4, 0})]
        [TestCase(1, 6 ,0, new double[] { -6, 0})]
        public void LogicalOperatorsTest4(double a, double b, double c, double[] expected)
        {
            double[] actual = HomeworkOnLogicalOperators.SolutionQuadraticEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(12, "Двенадцать")]
        [TestCase(22, "Двадцать два")]
        [TestCase(76, "Семдесят шесть")]
        public void LogicalOpertorsTest5(int a, string expected)
        {
            string actual = HomeworkOnLogicalOperators.ConvertngNumberToAString(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
