using NUnit.Framework;
using System;

namespace HW_1_3.Test
{
    public class ArraysTests
    {
        [TestCase(new int[] {1, 2, 3}, 1)]
        [TestCase(new int[] {-3, 0, -19}, -19)]
        [TestCase(new int[] {0}, 0)]
        [TestCase(new int[] {1, 2, 3, 3, 2, 1, 5, 7}, 1)]
        public static void FindMinElementTest(int[] array, int expectedResult)
        {
            double actualResult = Arrays.FindMinElement(array);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { })]
        public static void FindMinElementTest_WhenArrayIsEmpty_ShouldThrowExeption(int[] array)
        {
            Assert.Throws<Exception>(() => Arrays.FindMinElement(array));
        }

        [TestCase(new int[] {1, 2, 3}, 3)]
        [TestCase(new int[] {-3, 0, -19}, 0)]
        [TestCase(new int[] {0}, 0)]
        [TestCase(new int[] {1, 2, 7, 3, 2, 1, 5, 7}, 7)]
        public static void FindMaxElementTest(int[] array, int expectedResult)
        {
            double actualResult = Arrays.FindMaxElement(array);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { })]
        public static void FindMaxElementTest_WhenArrayIsEmpty_ShouldThrowExeption(int[] array)
        {
            Assert.Throws<Exception>(() => Arrays.FindMaxElement(array));
        }

        [TestCase(new int[] { 1, 2, 3 }, 0)]
        [TestCase(new int[] { -3, 0, -19 }, 2)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 1, 2, 7, 3, 2, 1, 5, 7 }, 0)]
        public static void FindIndexOfMinElementTest(int[] array, int expectedResult)
        {
            double actualResult = Arrays.FindIndexOfMinElement(array);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { })]
        public static void FindIndexOfMinElementTest_WhenArrayIsEmpty_ShouldThrowExeption(int[] array)
        {
            Assert.Throws<Exception>(() => Arrays.FindIndexOfMinElement(array));
        }

        [TestCase(new int[] { 1, 2, 3 }, 2)]
        [TestCase(new int[] { -3, 0, -19 }, 1)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 1, 2, 7, 3, 2, 1, 5, 7 }, 2)]
        public static void FindIndexOfMaxElementTest(int[] array, int expectedResult)
        {
            double actualResult = Arrays.FindIndexOfMaxElement(array);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { })]
        public static void FindIndexOfMaxElementTest_WhenArrayIsEmpty_ShouldThrowExeption(int[] array)
        {
            Assert.Throws<Exception>(() => Arrays.FindIndexOfMaxElement(array));
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 6)]
        [TestCase(new int[] { -3, 0, -19 , -4}, -4)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 1, 2, 7, 3, 2, 1, 5, 7 }, 13)]
        public static void CalculatesTheSumOfElementsWithOddIndicesTest(int[] array, int expectedResult)
        {
            double actualResult = Arrays.CalculatesTheSumOfElementsWithOddIndices(array);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { })]
        public static void CalculatesTheSumOfElementsWithOddIndicesTest_WhenArrayIsEmpty_ShouldThrowExeption(int[] array)
        {
            Assert.Throws<Exception>(() => Arrays.CalculatesTheSumOfElementsWithOddIndices(array));
        }


        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] {5, 4, 3, 2, 1 })]
        [TestCase(new int[] { -3, 0, -19, -4 }, new int[] {-4, -19, 0, -3 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 1, 2, 7, 3, 2, 1, 5, 7 }, new int[] {7, 5, 1, 2, 3, 7, 2, 1})]
        [TestCase(new int[] { }, new int[] { })]
        public static void ReverseTest(int[] array, int[] expectedResult)
        {
            int[] actualResult = Arrays.Reverse(array);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3)]
        [TestCase(new int[] { -3, 0, -19, -4 }, 2)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 8, 2, 4, 6, 2, 2, 6, 10 }, 0)]
        [TestCase(new int[] { }, 0)]
        public static void FindCountOfOddNumbersTest(int[] array, int expectedResult)
        {
            double actualResult = Arrays.FindCountOfOddNumbers(array);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 1, 2 })]
        [TestCase(new int[] { -3, 0, -19, -4 }, new int[] { -19, -4, -3, 0 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 1, 2, 7, 3, 2, 1, 5, 7 }, new int[] { 2, 1, 5, 7, 1, 2, 7, 3 })]
        [TestCase(new int[] { }, new int[] { })]
        public static void SwapHalfsTest(int[] array, int[] expectedResult)
        {
            int[] actualResult = Arrays.SwapHalfs(array);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { -3, 0, -19, -4 }, new int[] { -19, -4, -3, 0 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 1, 2, 7, 3, 2, 1, 5, 7 }, new int[] { 1, 1, 2, 2, 3, 5, 7, 7 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] {1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1})]
        public static void BubbleSortForTest(int[] array, int[] expectedResult)
        {
            int[] actualResult = Arrays.BubbleSortFor(array);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { -3, 0, -19, -4 }, new int[] { -19, -4, -3, 0 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 1, 2, 7, 3, 2, 1, 5, 7 }, new int[] { 1, 1, 2, 2, 3, 5, 7, 7 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1 })]
        public static void BubbleSortWhileTest(int[] array, int[] expectedResult)
        {
            int[] actualResult = Arrays.BubbleSortFor(array);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { -3, 0, -19, -4 }, new int[] {0, -3, -4, - 19 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 1, 2, 7, 3, 2, 1, 5, 7 }, new int[] { 7, 7, 5, 3, 2, 2, 1, 1 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1 })]
        public static void InsertSortReverseTest(int[] array, int[] expectedResult)
        {
            int[] actualResult = Arrays.InsertSortReverse(array);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { -3, 0, -19, -4 }, new int[] { -19, -4, -3, 0 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 1, 2, 7, 3, 2, 1, 5, 7 }, new int[] { 1, 1, 2, 2, 3, 5, 7, 7 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1 })]
        
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 }, true)]
        [TestCase(new int[] { -3, 0, -19, -4 }, new int[] { 0, -3, -4, -19 }, true)]
        [TestCase(new int[] { 0 }, new int[] { 0 }, true)]
        [TestCase(new int[] { 1, 2, 7, 3, 2, 1, 5, 7 }, new int[] { 7, 7, 5, 3, 2, 2, 1, 1 }, true)]
        [TestCase(new int[] { }, new int[] { }, true)]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1 }, true)]
        public static void SelectSortTest(int[] array, int[] expectedResult, bool reverse = false)
        {
            int[] actualResult = Arrays.SelectSort(array, reverse);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
