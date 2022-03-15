using NUnit.Framework;
using System;

namespace HW_1_3.Test
{
    public class TwoDimensionalArraysTests
    {
        [TestCase("sort", -2)]
        [TestCase("unsort", -9)]
        [TestCase("allZero", 0)]
        [TestCase("oneElement", 1)]
        public static void FindMinOfArrayTest(TDAMockType type, int expectedResult)
        {
            int[,] array = TwoDimensionalArraysMOCK.GetMOCK(type);
            int actualResult = TwoDimensionalArrays.FindMinOfArray(array);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestCase("empty")]
        public static void FindMinOfArrayTest_WhenArrayIsEmpty_ShouldThrowExceprtion(TDAMockType type)
        {
            int[,] array = TwoDimensionalArraysMOCK.GetMOCK(type);
            Assert.Throws<Exception>(() => TwoDimensionalArrays.FindMinOfArray(array));
        }
        [TestCase("sort", 9)]
        [TestCase("unsort", 9)]
        [TestCase("allZero", 0)]
        [TestCase("oneElement", 1)]
        public static void FindMaxOfArrayTest(TDAMockType type, int expectedResult)
        {
            int[,] array = TwoDimensionalArraysMOCK.GetMOCK(type);
            int actualResult = TwoDimensionalArrays.FindMaxOfArray(array);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestCase("empty")]
        public static void FindMaxOfArrayTest_WhenArrayIsEmpty_ShouldThrowExceprtion(TDAMockType type)
        {
            int[,] array = TwoDimensionalArraysMOCK.GetMOCK(type);
            Assert.Throws<Exception>(() => TwoDimensionalArrays.FindMaxOfArray(array));
        }

        [TestCase("sort", new int[] {0, 0})]
        [TestCase("unsort", new int[] { 1, 1 })]
        [TestCase("allZero", new int[] { 0, 0 })]
        [TestCase("oneElement", new int[] { 0, 0 })]
        public static void FindIndexOfMinTest(TDAMockType type, int[] expectedResult)
        {
            int[,] array = TwoDimensionalArraysMOCK.GetMOCK(type);
            int[] actualResult = TwoDimensionalArrays.FindIndexOfMin(array);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("empty")]
        public static void FindIndexOfMinTest_WhenArrayIsEmpty_ShouldThrowExceprtion(TDAMockType type)
        {
            int[,] array = TwoDimensionalArraysMOCK.GetMOCK(type);
            Assert.Throws<Exception>(() => TwoDimensionalArrays.FindIndexOfMin(array));
        }

        [TestCase("sort", new int[] { 3, 2 })]
        [TestCase("unsort", new int[] { 0, 1 })]
        [TestCase("allZero", new int[] { 0, 0 })]
        [TestCase("oneElement", new int[] { 0, 0 })]
        public static void FindIndexOfMaxTest(TDAMockType type, int[] expectedResult)
        {
            int[,] array = TwoDimensionalArraysMOCK.GetMOCK(type);
            int[] actualResult = TwoDimensionalArrays.FindIndexOfMax(array);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("empty")]
        public static void FindIndexOfMaxTest_WhenArrayIsEmpty_ShouldThrowExceprtion(TDAMockType type)
        {
            int[,] array = TwoDimensionalArraysMOCK.GetMOCK(type);
            Assert.Throws<Exception>(() => TwoDimensionalArrays.FindIndexOfMax(array));
        }
        [TestCase("sort", 1)]
        [TestCase("unsort", 3)]
        [TestCase("allZero", 0)]
        [TestCase("oneElement", 0)]
        public static void FindCountElementsHigherThanNeigborsTest(TDAMockType type, int expectedResult)
        {
            int[,] array = TwoDimensionalArraysMOCK.GetMOCK(type);
            int actualResult = TwoDimensionalArrays.FindCountElementsHigherThanNeigbors(array);
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestCase("square", "mirrorSquare")]
        public static void MirroredAlongTheMainDiagonalTest(TDAMockType typeBefore, TDAMockType typeAfter)
        {
            int[,] expectedResult = TwoDimensionalArraysMOCK.GetMOCK(typeAfter);
            int[,] array = TwoDimensionalArraysMOCK.GetMOCK(typeBefore);
            int[,] actualResult = TwoDimensionalArrays.MirroredAlongTheMainDiagonal(array);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
