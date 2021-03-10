using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace dz6.Tests
{
    class HomeworkOnVariablesTests
    {
        [TestCase(5, 4, -41)]
        [TestCase(0, 1, 1)]
        [TestCase(0.5d, 0.1d, -6.275d)]
        public void SolutionTest1(double a, double b, double expected)
        {
            double actual = HomeworkOnVariables.SolutionOfAGivenEquation(a, b);

            Assert.AreEqual(expected, actual, 0.00001);
        }



        [TestCase(2, 1, new int[] {2, 0})]
        [TestCase(12, 5, new int[] {2, 2})]
        [TestCase(100, 70, new int[] {1, 30})]
        public void SolutionTest2(int a, int b, int[] expected)
        {
            int[] actual = HomeworkOnVariables.DivisionResult(a, b);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(1, 2, 3, 1)]
        [TestCase(2, 2, 0, -1)]
        [TestCase(3, 2, 0, -0.66666666)]
        public void SolutionTest3(int a, int b, int c, double expected)
        {
            double actual = HomeworkOnVariables.SolutionLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual, 0.00001);
        }



        [TestCase(5, 1, 3, 7, "Y = -3X + 16")]
        [TestCase(2, 4, 7, 0, "Y = -0,8X + 5,6")]
        [TestCase(-1, 20, 5, -4, "Y = -4X + 16")]
        public void SolutionTest4(int x1, int y1, int x2, int y2, string expected)
        {
            string actual = HomeworkOnVariables.DescriptionOfTheEquationPassingThroughtThePoints(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }
    }

}
