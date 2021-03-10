using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace dz6.Tests
{
    class HomeworkOnOneArraysTests
    {
        [TestCase(new int[] { 4, 8, 15, 16, 23, 42 }, 4)]
        [TestCase(new int[] { 4, 8, -6, 16, 23, 42, -4 }, -6)]
        [TestCase(new int[] { 4, 8, -6, 16, 23, -42, -4, 88, 109, 0 }, -42)]
        public void OneArraysTest1(int[] a, int expected)
        {
            int actual = HomeworkOnOneArrays.FindTheMinimumElementOfAnArray(a);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(new int[] { 4, 8, 15, 16, 23, 42 }, 42)]
        [TestCase(new int[] { 4, 8, -6, 16, 23, -4 }, 23)]
        [TestCase(new int[] { 4, 8, -6, 16, 23, -42, -4, 88, 109, 0 }, 109)]
        public void OneArraysTest2(int[] a, int expected)
        {
            int actual = HomeworkOnOneArrays.FindTheMaximumElementOfAnArray(a);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(new int[] { 4, 8, 15, 16, 23, 42 }, 0)]
        [TestCase(new int[] { 4, 8, -6, 16, 23, -4 }, 2)]
        [TestCase(new int[] { 4, 8, -6, 16, 23, -42, -4, 88, 109, 0 }, 5)]
        public void OneArraysTest3(int[] a, int expected)
        {
            int actual = HomeworkOnOneArrays.FindTheIndexMinimumElement(a);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(new int[] { 4, 8, 15, 16, 23, 42 }, 5)]
        [TestCase(new int[] { 4, 8, -6, 16, 23, -4 }, 4)]
        [TestCase(new int[] { 4, 8, -6, 16, 23, -42, -4, 88, 109, 0 }, 8)]
        public void OneArraysTest4(int[] a, int expected)
        {
            int actual = HomeworkOnOneArrays.FindTheIndexMaximumElement(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 4, 8, 15, 16, 23, 42 }, 66)]
        [TestCase(new int[] { 4, 8, -6, 16, 23, -4 }, 20)]
        [TestCase(new int[] { 4, 8, -6, 16, 23, -42, -4, 88, 109, 0 }, 70)]
        public void OneArraysTest5(int[] a, int expected)
        {
            int actual = HomeworkOnOneArrays.CalculatingSumItemsOddIndex(a);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(new int[] { 4, 8, 15, 16, 23, 42 }, new int[] {42, 23, 16, 15, 8, 4})]
        [TestCase(new int[] { 4, 8, -6, 16, 23, -4 }, new int[] {-4, 23, 16, -6, 8, 4})]
        [TestCase(new int[] { 4, 8, -6, 16, 23, -42, -4, 88, 109, 0 }, new int[] { 0, 109, 88, -4, -42, 23, 16, -6, 8, 4 })]
        public void OneArraysTest6(int[] a, int[] expected)
        {
            int[] actual = HomeworkOnOneArrays.ReverseArray(a);
            Assert.AreEqual(expected, actual);
        }



    }
}
