using System;

namespace HW_1_3
{
    public static class Variablies
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
            mod = a % b;
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
            double result = ((5 * a + b * b) / (b - a));
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

        /// <summary>
        /// 4. Выводит в консоль решение(значение X) линейного уравнения 
        /// стандартного вида,где A*X+B=C.
        /// </summary>
        public static double FindTheRootOfaLinearEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("Уравнение имеет бесконечно много корней. Параметр A равен нулю");
            }
            double x = ((c - b) / a);
            return Math.Round(x,2);
        }

        /// <summary>
        /// 5. Выводит уравнение прямой в формате Y=AX+B, проходящей через точки (X1, Y1, X2, Y2).
        /// </summary>

        public static string FindEquationsByTwoPoints(double x1, double y1, double x2, double y2)
        {
            if (y1 == y2)
            {
                throw new Exception("Такой прямой формата Y=AX+B не существует: y1 == y2");
            }
            if ((y1 == y2) && (x1 == x2) && (x1 == y1))
            {
                throw new Exception($"Прямая проходит через одну точку ({x1}, {y2}), Бесконечно много прямых формата Y=AX+B");
            }

            if (x1 == x2)
            {
                return $"Уравнение прямой Y = {x1}";
            }
            else
            {
                double A = Math.Round((y1 - y2) / (x1 - x2), 2);
                double B = Math.Round(y2 - A * x2, 2);

                return $"Уравнение прямой Y = {A} * X + {B}";
            }
        }
        public static void ChangeNumbers(ref int a, ref int b)
        {
            int tmp = b;
            b = a;
            a = tmp;
        }
    }
}
