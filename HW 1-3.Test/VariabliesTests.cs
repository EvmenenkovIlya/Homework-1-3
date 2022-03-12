using NUnit.Framework;
using System;

namespace HW_1_3.Test
{
    public class VariabliesTests
    {
        [TestCase(10, 3, 3, 1)]
        [TestCase(10, 2, 5, 0)]
        [TestCase(4, 5, 0, 4)]
        [TestCase(-5, -3, 1, -2)]
        [TestCase(-5, 2, -2, -1)]
        public void FindingDivAndModTest(int a, int b, int expectedDiv, int expectedMod)
        {
            int actualDiv;
            int actualMod;
            Variablies.FindingDivAndMod(a, b, out actualDiv, out actualMod);
            Assert.AreEqual(expectedMod, actualMod);
            Assert.AreEqual(expectedDiv, actualDiv);
        }

        [TestCase(10, 0)]
        [TestCase(0, 0)]
        [TestCase(-53, 0)]
        public void FindingDivAndModTest_WhenBIsZero_ShouldThrowExeption(int a, int b)
        {
            int div;
            int mod;
            Assert.Throws<Exception>(() => Variablies.FindingDivAndMod(a, b, out div, out mod));
        }

        [TestCase(10, 5, -15)]
        [TestCase(0, 5, 5)]
        [TestCase(10, 0, -5)]
        [TestCase(-12, -4, -5.5)]
        public static void FindTheValueOfTheExpressionTest(double a, double b, double expected)
        {
            double actual = Variablies.FindTheValueOfTheExpression(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 10, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(-4, -4, 0)]
        public static void FindTheValueOfTheExpressionTest_WhenAIsEqualB_ShouldThrowExeption(double a, double b, double expected)
        {
            Assert.Throws<Exception>(() => Variablies.FindTheValueOfTheExpression(a, b));
        }

        [TestCase("", "", "", "")]
        [TestCase("Abc", "", "", "Abc")]
        [TestCase(" ", " ", " ", " ")]
        [TestCase("", "CBA", "CBA", "")]
        [TestCase("ABC", "CBA", "CBA", "ABC")]
        public static void SwapVariablesTest(string First, string Second, string expectedFirstString, string expectedSecondString)
        {
            string actualFirstString = First;
            string actualSecondString = Second;
            Variablies.SwapVariables(ref actualFirstString, ref actualSecondString);
            Assert.AreEqual(expectedFirstString, actualFirstString);
            Assert.AreEqual(expectedSecondString, actualSecondString);
        }
        [TestCase(1, 2, 3, 1)]
        [TestCase(3, 2, 1, -0.33)]
        [TestCase(2, 3, 0, -1.5)]
        [TestCase(2, 0, 3, 1.5)]
        [TestCase(2, 0, 0, 0)]
        public static void FindTheRootOfaLinearEquationTest(double a, double b, double c, double expectedX)
        {
            double actualX = Variablies.FindTheRootOfaLinearEquation(a, b, c);
            Assert.AreEqual(expectedX, actualX);
        }

        [TestCase(0, 3, 2)]
        [TestCase(0, 0, 0)]
        public static void FindTheRootOfaLinearEquationTest_WhenAIsEqualZero_ShouldThrowExeption(double a, double b, double c)
        {
            Assert.Throws<Exception>(() => Variablies.FindTheRootOfaLinearEquation(a, b, c));
        }

        [TestCase(1, 1, 2, 2, "Уравнение прямой Y = 1 * X + 0")]
        [TestCase(1, 2, 2, 1, "Уравнение прямой Y = -1 * X + 3")]
        [TestCase(-3, -3, -6, -8, "Уравнение прямой Y = 1,67 * X + 2,02")]        
        public static void FindEquationsByTwoPointsTest(double x1, double y1, double x2, double y2, string expectedResult)
        {
            string actualResult = Variablies.FindEquationsByTwoPoints(x1, y1, x2, y2);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestCase(1, 2, 2, 2)]
        [TestCase(8, -4, 6, -4)]
        public static void FindEquationsByTwoPointsTest_WhenY1IsEqualY2_ShouldThrowExeption(double x1, double y1, double x2, double y2)
        {
            Assert.Throws<Exception>(() => Variablies.FindEquationsByTwoPoints(x1, y1, x2, y2));
        }
        [TestCase(2, 2, 2, 2)]
        [TestCase(0, 0, 0, 0)]
        public static void FindEquationsByTwoPointsTest_WhenAllPointAreEqual_ShouldThrowExeption(double x1, double y1, double x2, double y2)
        {
            Assert.Throws<Exception>(() => Variablies.FindEquationsByTwoPoints(x1, y1, x2, y2));
        }
    }
}