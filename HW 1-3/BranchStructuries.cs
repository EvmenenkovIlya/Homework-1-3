using System;

namespace HW_1_3
{
    internal class BranchStructuries
    {
        /* Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, 
         * если A=B, подсчитать A*B, если A<B, подсчитать A-B.*/
        public static int FindSumOrDifferenceOrProduct(int a, int b)
        {
            if (a > b)
            {
                return (a + b);
            }
            else if (a == b)
            {
                return (a * b);
            }
            else
            {
                return (a - b);
            }
        }

        /* Пользователь вводит 2 числа(X и Y). Определить какой четверти принадлежит точка 
        * с координатами(X, Y).*/
        public static string FindTheQuarterPoint(double X, double Y)
        {

            if (X > 0 && Y > 0)
            {
                return "Первая четверть";
            }
            else if (X < 0 && Y > 0)
            {
                return "Вторая четверть";
            }
            else if (X < 0 && Y < 0)
            {
                return "Третья четверть";
            }
            else if (X > 0 && Y < 0)
            {
                return "Четвертая четверть";
            }
            else
            {
                return "Точка на одной из осей";
            }
        }

        /* Пользователь вводит 3 числа(A, B и С).
         * Выведите их в консоль в порядке возрастания.*/
        public static void SortByIncrease(int a, int b, int c)
        {

        }

        /* Пользователь вводит 3 числа(A, B и С).Выведите в консоль решение(значения X) 
         * квадратного уравнения стандартного вида, где */
        public static void FindSolutionsToAQuadraticEquation(int a, int b, int c)
        {

        }

        /* Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа. 
         * Например при вводе “25” в консоль будет выведено “двадцать пять”. */
        public static string WriteNumberByText(int number)
        {
            string first = "";
            string second = "";
            if (number > 19)
            {
                switch (number / 10)
                {
                    case (2): first = "Двадцать"; break;
                    case (3): first = "Тридцать"; break;
                    case (4): first = "Сорок"; break;
                    case (5): first = "Пятьдесят"; break;
                    case (6): first = "Шестьдесят"; break;
                    case (7): first = "Семьдесят"; break;
                    case (8): first = "Восемьдесят"; break;
                    case (9): first = "Девяносто"; break;
                }
                switch (number % 10)
                {
                    case (0): second = ""; break;
                    case (1): second = "один"; break;
                    case (2): second = "два"; break;
                    case (3): second = "три"; break;
                    case (4): second = "четыре"; break;
                    case (5): second = "пять"; break;
                    case (6): second = "шесть"; break;
                    case (7): second = "семь"; break;
                    case (8): second = "восемь"; break;
                    case (9): second = "девять"; break;
                }
                return $"{first} {second}";
            }
            else
            {
                switch (number)
                {
                    case (10): first = "Десять"; break;
                    case (11): first = "Одиннадцать"; break;
                    case (12): first = "Двенадцать"; break;
                    case (13): first = "Тринадцать"; break;
                    case (14): first = "Четырнадцать"; break;
                    case (15): first = "Пятнадцать"; break;
                    case (16): first = "Шестнадцать"; break;
                    case (17): first = "Семнадцать"; break;
                    case (18): first = "Восемнадцать"; break;
                    case (19): first = "Девятнадцать"; break;
                }
                return $"{first}";
            }
        }
    }
}
