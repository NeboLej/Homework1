using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace dz6.Tests
{
    class HomeworkOnCyclesTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(2, 3, 8)]
        [TestCase(3, 3, 27)]
        public void CyclesTest1(int a, int b, int expected)
        {
            int actual = HomeworkOnCycles.Exponention(a, b);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(30, new int[] {30, 60, 90, 120, 150, 180, 210, 240, 270, 300, 330, 360, 390, 420, 450, 480, 510, 540, 570, 600, 630, 660, 690, 720, 750, 780, 810, 840, 870, 900, 930, 960, 990})]
        [TestCase(150, new int[] {150, 300, 450, 600, 750, 900})]
        [TestCase(430, new int[] {430, 860})]
        public void CyclesTest2(int a, int[] expected)
        {
            int[] actual = HomeworkOnCycles.DivisionByNymber(a);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(40, 6)]
        [TestCase(6, 2)]
        [TestCase(100, 9)]
        public void CyclesTest3(int a, int expected)
        {
            int actual = HomeworkOnCycles.FindTheNumberWhoseSquareIsLess(a);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(40, 20)]
        [TestCase(6, 3)]
        [TestCase(71, 1)]
        public void CyclesTest4(int a, int expected)
        {
            int actual = HomeworkOnCycles.FindTheGreatestDivision(a);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(-5, 10, 7)]
        [TestCase(-7, 10, 0)]
        [TestCase(0, 14, 21)]
        public void CyclesTest5(int a, int b, int expected)
        {
            int actual = HomeworkOnCycles.FindTheSumOfNumbersDivisibleBySeven(a, b);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(8, 13)]
        [TestCase(12, 89)]
        [TestCase(19, 2584)]
        public void CyclesTest6(int a, int expected)
        {
            int actual = HomeworkOnCycles.FindTheNumberOfTheFibonacciSeries(a);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(8, 24, 8)]
        [TestCase(27, 6, 3)]
        [TestCase(1000, 350, 50)]
        public void CyclesTest7(int a, int b, int expected)
        {
            int actual = HomeworkOnCycles.FindTheGreatestCommonFactor(a, b);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(27, 3)]
        [TestCase(125000000, 500)]
        [TestCase(8, 2)]
        public void CyclesTest8(double a, int expected)
        {
            double actual = HomeworkOnCycles.FindACubeByBinaryMethod(a);
            Assert.AreEqual(expected, actual, 0.00001);
        }



        [TestCase(27, 1)]
        [TestCase(567037, 4)]
        [TestCase(88842, 0)]
        public void CyclesTest9(int a, int expected)
        {
            int actual = HomeworkOnCycles.FindTheNumberOfOddNumbers(a);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(27, 72)]
        [TestCase(567037, 730765)]
        [TestCase(88842, 24888)]
        public void CyclesTest10(int a, int expected)
        {
            int actual = HomeworkOnCycles.FindTheMirrorNumber(a);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(27, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24, 26 })]
        [TestCase(5, new int[] {2, 4})]
        [TestCase(32, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24, 26, 28})]
        public void CyclesTest11(int a, int[] expected)
        {
            int[] actual = HomeworkOnCycles.FindNumberrsSumOddGreaterSumEven(a);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(27, 88, false)]
        [TestCase(5, 756, true)]
        [TestCase(32,9072, true)]
        public void CyclesTest12(int a, int b, bool expected)
        {
            bool actual = HomeworkOnCycles.FindTheSameNumbers(a ,b);
            Assert.AreEqual(expected, actual);
        }





    }


}
