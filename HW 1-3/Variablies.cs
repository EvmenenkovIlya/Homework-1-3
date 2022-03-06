using System;

namespace HW_1_3
{
    static class Variablies
    {

        /// <summary>
        /// 1. Возвращает результат деления A на B (div) и остаток от деления (mod)
        /// </summary>
        public static void FindingDivAndMod(int a, int b, out int div, out int mod)
        {
            if (b == 0)
            {
                throw new Exception("Делитель b равен нулю.");
            }
            div = a / b;
            mod = b;
        }

        /// <summary>
        /// 2. Выводит в консоль решение (5 * A + B^2) / (B - A)
        /// </summary>
        public static double FindTheValueOfTheExpression(double a, double b)
        {
            if (b == a)
            {
                throw new Exception("Делитель вырежения равен нулю, т.к. Равны a и b.");
            }
            double result = ((5 * a + b * b) / (b - 1));
            return result;
        }

        /// <summary>
        /// 3. Меняет содержимое строк местами.
        /// </summary>

        public static void SwapVariables(ref string a, ref string b)
        {
            string tmp = b;
            b = a; 
            a = tmp;
        }

        /* 4. Пользователь вводит 3 не равных 0 числа (A, B и С).
           */

        /// <summary>
        /// 3. Выводит в консоль решение(значение X) линейного уравнения 
        /// стандартного вида,где A*X+B=C.
        /// </summary>
        public static double FindTheRootOfaLinearEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("Уравнение имеет бесконечно много корней. Параметр A равен нулю");
            }
            double x = ((c - b) / a);
            return x;
        }

        /// <summary>
        /// Выводит уравнение прямой в формате Y=AX+B, проходящей через точки (X1, Y1, X2, Y2).
        /// </summary>

        public static string FindEquationsByTwoPoints(double x1, double y1, double x2, double y2)
        {

            if (x1 == x2)
            {
                return $"Уравнение прямой X = {x1}";
            }
            else if (y1 == y2)
            {
                return $"Уравнение прямой Y = {y1}";
            }
            else
            {
                double A = (y1 - y2) / (x1 - x2);
                double B = y2 - A * x2;

                return $"Уравнение прямой Y = {A} * X + {B}";
            }
        }

    }
}
