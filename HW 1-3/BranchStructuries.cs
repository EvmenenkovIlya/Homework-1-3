using System;

namespace HW_1_3
{
    internal class BranchStructuries
    {

        /// <summary>
        /// 1. Если A>B, возвращает A+B, если A = B, возвращает A* B, если A<B, возвращает A-B.
        /// </summary>
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

        /// <summary>
        /// 2. Определяет какой четверти принадлежит точка с координатами(X, Y).
        /// </summary>
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

        /// <summary>
        /// 3. Возвращает кортеж отсортированных чисел A, B, C.
        /// </summary>
        public static (int, int, int) SortByIncrease(int A, int B, int C)
        {
            if (A <= B && A <= C)
            {
                if (B <= C)
                {
                    return (A, B, C);
                }
                else
                {
                    return (A, C, B);
                }
            }
            else if (B <= C && B <= A)
            {
                if (A <= C)
                {
                    return (B, A, C);
                }
                else
                {
                    return (B, C, A);
                }
            }
            else
            {
                if (A <= B)
                {
                    return (C, A, B);
                }
                else
                {
                    return (C, B, B);
                }
                
            }
        }

        /// <summary>
        /// 4. Выводит в консоль решение(значения X) 
        /// квадратного уравнения стандартного вида, где A* X * X + B* X + C = 0
        /// </summary>
        public static void FindSolutionsToAQuadraticEquation(int A, int B, int C)
        {
            double D = B * B - 4 * A * C;
            double X1, X2;

            if (D == 0)
            {
                X1 = -B / (2 * A);
                Console.WriteLine($"У уравнения один корень: {X1}");
            }
            else if (D > 0)
            {
                X1 = (-B - Math.Sqrt(D)) / (2 * A);
                X2 = (-B + Math.Sqrt(D)) / (2 * A);
                Console.WriteLine($"У уравнения два корня: {X1} и {X2}");
            }
            else
            {
                Console.WriteLine("У уравнения нет корней в области вещественных чисел");
            }
        }

        /// <summary>
        /// 5. Выводит в консоль прописную запись двухзначного числа числа.
        /// </summary>
        public static string WriteNumberByText(int number)
        {
            string first = "";
            string second = "";

            if ((number < 10) || (number > 99))
            {
                throw new Exception("Число не двухзначное!");
            }

            if (number > 19)
            {
                switch (number / 10)
                {
                    case (2): first = "Двадцать"; 
                        break;
                    case (3): first = "Тридцать"; 
                        break;
                    case (4): first = "Сорок"; 
                        break;
                    case (5): first = "Пятьдесят"; 
                        break;
                    case (6): first = "Шестьдесят";
                        break;
                    case (7): first = "Семьдесят"; 
                        break;
                    case (8): first = "Восемьдесят"; 
                        break;
                    case (9): first = "Девяносто";
                        break;
                }
                switch (number % 10)
                {
                    case (0): second = ""; 
                        break;
                    case (1): second = "один"; 
                        break;
                    case (2): second = "два"; 
                        break;
                    case (3): second = "три"; 
                        break;
                    case (4): second = "четыре";
                        break;
                    case (5): second = "пять"; 
                        break;
                    case (6): second = "шесть";
                        break;
                    case (7): second = "семь"; 
                        break;
                    case (8): second = "восемь"; 
                        break;
                    case (9): second = "девять"; 
                        break;
                }
                return $"{first} {second}";
            }
            else
            {
                switch (number)
                {
                    case (10): first = "Десять"; 
                        break;
                    case (11): first = "Одиннадцать"; 
                        break;
                    case (12): first = "Двенадцать"; 
                        break;
                    case (13): first = "Тринадцать"; 
                        break;
                    case (14): first = "Четырнадцать"; 
                        break;
                    case (15): first = "Пятнадцать"; 
                        break;
                    case (16): first = "Шестнадцать";
                        break;
                    case (17): first = "Семнадцать";
                        break;
                    case (18): first = "Восемнадцать"; 
                        break;
                    case (19): first = "Девятнадцать"; 
                        break;
                }
                return $"{first}";
            }
        }
    }
}
