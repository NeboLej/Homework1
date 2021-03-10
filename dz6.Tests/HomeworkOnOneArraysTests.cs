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



        [TestCase(new int[] { 4, 8, 15, 16, 23, 42 }, 2)]
        [TestCase(new int[] { 4, 8, -6, 16, 23, -4 }, 1)]
        [TestCase(new int[] { 4, 8, -6, 16, 23, -42, -4, 88, 109, 0 }, 2)]
        public void OneArraysTest7(int[] a, int expected)
        {
            int actual = HomeworkOnOneArrays.CountTheNumnerOfOddItems(a);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(new int[] { 4, 8, 15, 16, 23, 42 }, new int[] { 16, 23, 42, 4, 8, 15})]
        [TestCase(new int[] { 4, 8, 15, 16, 23, 42, 67}, new int[] { 23, 42, 67, 16, 4, 8, 15})]
        [TestCase(new int[] { 4, 8, 15}, new int[] { 15, 8, 4})]
        public void OneArraysTest8(int[] a, int[] expected)
        {
            int[] actual = HomeworkOnOneArrays.SwapFirstAndSecondHalf(a);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(new int[] { 4, 8, 15, 16, 23, 42 }, new int[] { 4, 8, 15, 16, 23, 42})]
        [TestCase(new int[] { 23, 4, 8, 67, 15, 16, 42, -70}, new int[] { -70, 4, 8, 15, 16, 23, 42, 67})]
        [TestCase(new int[] { 4, 8, 15}, new int[] { 4, 8, 15})]
        public void OneArraysTest9(int[] a, int[] expected)
        {
            int[] actual = HomeworkOnOneArrays.SortSelectArray(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] {2, 8, 1}, new int[] {8, 2, 1})]
        [TestCase(new int[] {2, 18, 21, -8, 100, 9}, new int[] { 100, 21, 18, 9, 2, -8 })]
        [TestCase(new int[] {-2, -8, -1, 7, 1, 0}, new int[] { 7, 1, 0, -1, -2, -8 })]
        public void OneArraysTest10(int[] a, int[] expected)
        {
            int[] actual = HomeworkOnOneArrays.SortBubbleArray(a);
            Assert.AreEqual(expected, actual);
        }









    }
}
