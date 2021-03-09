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
        public void SolutionTest(double a, double b, double expected)
        {
            double actual = HomeworkOnVariables.SolutionOfAGivenEquation(a, b);

            Assert.AreEqual(expected, actual,0.00001);
        }

    }
}
