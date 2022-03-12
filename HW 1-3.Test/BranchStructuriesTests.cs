using NUnit.Framework;
using System;

namespace HW_1_3.Test
{
    public class BranchStructuriesTests
    {
        [TestCase(10, 3, 13)]
        [TestCase(11, 10, 21)]
        [TestCase(4, 4, 16)]
        [TestCase(0, 0, 0)]
        [TestCase(-5, 2, -7)]
        [TestCase(2, 3, -1)]
        public void FindSumOrDifferenceOrProductTest(int a, int b, int expectedResult)
        {
            int actualResult = BranchStructuries.FindSumOrDifferenceOrProduct(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestCase(1, 2, 3, new int[] {1, 2, 3})]
        [TestCase(0, 0, 0, new int[] {0, 0, 0})]
        [TestCase(3, 2, 1, new int[] {1, 2, 3})]
        [TestCase(-5, 2, -5, new int[] {-5, -5, 2})]
        public static void SortByIncreaseTest(int A, int B, int C, int[] expectedResult)
        {
            int[] actualResult = BranchStructuries.SortByIncrease(A, B, C);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(3, 2, 1, new double[] {})]
        [TestCase(5, 4, 2, new double[] {})]
        [TestCase(1, 4, 4, new double[] {-2})]
        [TestCase(5, 0, 0, new double[] {0})]
        [TestCase(2, 3, -4, new double[] { -2.35, 0.85 })]
        [TestCase(16, 0, -4, new double[] { -0.5, 0.5 })]
        public static void FindSolutionsToAQuadraticEquationTest(double A, double B, double C, double[] expectedResult)
        {
            double[] actualResult = BranchStructuries.FindSolutionsToAQuadraticEquation(A, B, C);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0, 3, 2)]
        [TestCase(0, 0, 0)]
        public void FindSolutionsToAQuadraticEquationTest_WhenParameterAIsEqualZero_ShouldThrowExeption(double A, double B, double C)
        {
            Assert.Throws<Exception>(() => BranchStructuries.FindSolutionsToAQuadraticEquation(A, B, C));
        }

        [TestCase(10, 3, "Первая четверть")]
        [TestCase(11, 10, "Первая четверть")]
        [TestCase(-15, 10, "Вторая четверть")]
        [TestCase(-3, 2, "Вторая четверть")]
        [TestCase(-15, -10, "Третья четверть")]
        [TestCase(-3, -2, "Третья четверть")]
        [TestCase(5, -4, "Четвертая четверть")]
        [TestCase(3, -2, "Четвертая четверть")]
        [TestCase(0, 0, "Точка на одной из осей")]
        [TestCase(-3, 0, "Точка на одной из осей")]
        [TestCase(0, 5, "Точка на одной из осей")]
        public static void FindTheQuarterPointTest(double X, double Y, string expectedResult)
        {
            string actualResult = BranchStructuries.FindTheQuarterPoint(X, Y);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10, "Десять")]
        [TestCase(27, "Двадцать семь")]
        [TestCase(84, "Восемьдесят четыре")]
        public static void WriteNumberByTextTest(int number, string expectedResult)
        {
            string actualResult = BranchStructuries.WriteNumberByText(number);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(9)]
        [TestCase(111)]
        public void WriteNumberByTextTest_WhenNumberIsNotTwoDigit_ShouldThrowExeption(int number)
        {
            Assert.Throws<Exception>(() => BranchStructuries.WriteNumberByText(number));
        }
    }
}
