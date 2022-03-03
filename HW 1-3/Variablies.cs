using System;

namespace HW_1_3
{
    static class Variablies
    {
        /* Пользователь вводит 2 числа (A и B).
           Выведите в консоль результат деления A на B и остаток от деления.*/
        public static void FindingDivAndMod(int a, int b)
        {
        
        }

        /* Пользователь вводит 2 числа (A и B).
           Выведите в консоль решение (5 * A + B^2) / (B - A)*/
        public static double FindTheValueOfTheExpression(double a, double b)
        {
            double result = ((5 * a + b * b) / (b - 1));
            return result;
        }

        /* Пользователь вводит 2 строковых(string) значения(A и B).
           Поменяйте содержимое переменных A и B местами.*/
        public static void SwapVariableWithEachOther(int a, int b)
        {
        
        }

        /* Пользователь вводит 3 не равных 0 числа (A, B и С).
           Выведите в консоль решение(значение X) линейного уравнения стандартного вида,
           где A*X+B=C.*/
        public static double FindTheRootOfaLinearEquation(double a, double b, double c)
        {
            double x = ((c - b) / a);
            return x;
        }

        /* Пользователь вводит 4 числа (X1, Y1, X2, Y2), 
           описывающие координаты 2-х точек на координатной плоскости. 
           Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.*/
        public static string FindEquationsByTwoPoints(double x1, double y1, double x2, double y2)
        {
            double A = (y1 - y2) / (x1 - x2);
            double B = y2 - A * x2;
            
            return $"Уравнение прямой Y = {A} * X + {B}";
        }



    }
}
