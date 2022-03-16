using NUnit.Framework;
using System;

namespace HW_1_3.Test
{
    public class CyclesTests
    {
        [TestCase(10, 0, 1)]
        [TestCase(0, 0, 1)]
        [TestCase(3, 3, 27)]
        [TestCase(2, -2, 0.25)]
        [TestCase(-3, 3, -27)]
        public void ExponentiateTest(double a, double b, double expectedResult)
        {
            double actualResult = Cycles.Exponentiate(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestCase(300, new int[] { 300, 600, 900 })]
        [TestCase(100, new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 })]
        public void FindDivisibleNumbersTest(int a, int[] expectedResult)
        {
            int[] actualResult = Cycles.FindDivisibleNumbers(a);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestCase(0)]
        [TestCase(-15)]
        [TestCase(1000)]
        [TestCase(13600)]
        public static void FindDivisibleNumbersTest_WhenAIsMoreThenThousandOrLessThenZero_ShouldThrowExeption(int a)
        {
            Assert.Throws<Exception>(() => Cycles.FindDivisibleNumbers(a));
        }

        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(2, 1)]
        [TestCase(8, 2)]
        [TestCase(10, 3)]
        public static void ReturnCountOfNumbersSquareLessThanATest(int a, int expectedResult)
        {
            int actualResult = Cycles.ReturnCountOfNumbersSquareLessThanA(a);
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestCase(1, 1)]
        [TestCase(15, 5)]
        [TestCase(1000, 500)]
        public static void FindTheLargestDivisorTest(int a, int expectedResult)
        {
            int actualResult = Cycles.FindTheLargestDivisor(a);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0)]
        [TestCase(-15)]
        public static void FindTheLargestDivisorTest_WhenAIsLessThenZero_ShouldThrowExeption(int a)
        {
            Assert.Throws<Exception>(() => Cycles.FindTheLargestDivisor(a));
        }

        [TestCase(24, 0, 42)]
        [TestCase(0, 14, 21)]
        [TestCase(-14, 20, 0)]
        public static void FindSumAllNumbersWhichAreDividedInto7Test(int a, int b, int expectedResult)
        {
            int actualResult = Cycles.FindSumAllNumbersWhichAreDividedInto7(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(7, 13)]
        public static void FindFibonacciNumberTest(int N, int expectedResult)
        {
            int actualResult = Cycles.FindFibonacciNumber(N);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestCase(0)]
        [TestCase(-20)]
        public static void FindFibonacciNumber_WhenNumberIsLessThenZero_ShouldThrowExeption(int N)
        {
            Assert.Throws<Exception>(() => Cycles.FindFibonacciNumber(N));
        }
        [TestCase(1, 1, 1)]
        [TestCase(1000, 2, 2)]
        [TestCase(1000, 3, 1)]
        [TestCase(18, -24, 6)]
        public static void FindGreatestCommonDivisorOfTwoNumbersTest(int a, int b, int expectedResult)
        {
            int actualResult = Cycles.FindGreatestCommonDivisorOfTwoNumbers(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0, 0)]
        public static void FindGreatestCommonDivisorOfTwoNumbersTest_WhenAAndBIsZero_ShouldThrowExeption(int a, int b)
        {
            Assert.Throws<Exception>(() => Cycles.FindGreatestCommonDivisorOfTwoNumbers(a, b));
        }
        [TestCase(0, 0)]
        [TestCase(8, 2)]
        [TestCase(9, 2.08)]
        [TestCase(27, 3)]
        [TestCase(1, 1)]
        public static void FindThirdRootTest(double N, double expectedResult)
        {
            double actualResult = Cycles.FindThirdRoot(N);
            Assert.AreEqual(expectedResult, actualResult, 0.01);
        }
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(1235, 3)]
        [TestCase(2468, 0)]
        public static void FindCountOfOddNumbersTest(int N, int expectedResult)
        {
            int actualResult = Cycles.FindCountOfOddNumbers(N);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1235, 5321)]
        [TestCase(0, 0)]
        [TestCase(1000, 1)]
        public static void FindMirrorNumberTest(int N, int expectedResult)
        {
            int actualResult = Cycles.FindMirrorNumber(N);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestCase(1, new int[] { })]
        [TestCase(10, new int[] {2, 4, 6, 8 })]
        [TestCase(5, new int[] { 2, 4 })]
        public static void WriteNumberIfCountOfEvenMoreThanOddTest(int N, int[] expectedResult)
        {
            int[] actualResult = Cycles.WriteNumberIfCountOfEvenMoreThanOdd(N);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0)]
        [TestCase(-8)]
        public static void WriteNumberIfCountOfEvenMoreThanOddTest_WhenNumberLessThenZero_ShouldThrowExeption(int N)
        {
            Assert.Throws<Exception>(() => Cycles.WriteNumberIfCountOfEvenMoreThanOdd(N));
        }

        [TestCase(1235, 5321, true)]
        [TestCase(1235, 4896, false)]
        [TestCase(1, 1, true)]
        [TestCase(0, 0, true)]
        [TestCase(-30, 303, true)]
        [TestCase(303, 0, true)]
        [TestCase(0, 303, true)]

        public static void ThereAreTheSameNumbersTest(int a, int b, bool expectedResult)
        {
            bool actualResult = Cycles.ThereAreTheSameNumbers(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }

}
