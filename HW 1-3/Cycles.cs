using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1_3
{
    internal class Cycles
    {
        public static void ChangeNumbers(ref int a, ref int b)
        {
            if (b < a)
            {
                int tmp = b;
                b = a;
                a = tmp;
            }
        }

        /// <summary>
        /// 1. Возводит число a в степень b.
        /// </summary>
        /// <returns>Число a в степени b </returns>
        public static double Exponentiate(double a, double b)
        {
            double tmp = 1;

            if (b < 0)
            {
                a = 1 / a;
                b = Math.Abs(b);
            }
            while (b != 0)
            {
                tmp *=  a;
                b--;
            }
            return tmp;
        }        
        
        /// <summary>
        /// 2. *Выводит все числа от 1 до 1000, которые делятся на A.
        /// </summary>
        public static void FindDivisibleNumbers(int a)
        {
            int tmp = a;
            if (a < 0)
            {
                tmp = Math.Abs(a);
            }
            for (int i = a; i <= 1000; i += tmp)
            {
                if (i == 0)
                {
                    continue;
                }

               Console.Write($"{i} ");
            }
        }

        /// <summary>
        /// 3. Возвращает количество положительных целых чисел, квадрат которых меньше A.
        /// </summary>
        public static int ReturnCountOfNumbersSquareLessThanA(int a)
        {
            int countOfNumbers = 0;
            while (countOfNumbers * countOfNumbers < a)
            {
                countOfNumbers++;
            }

            return countOfNumbers;
        }

        /// <summary>
        /// 4. Возвращает наибольший делитель (кроме самого A) числа A.
        /// </summary>
        public static int FindTheLargestDivisor(int a)
        {
            int i = a - 1;

            if (a <= 0)
            {
                throw new Exception("A <= 0. Число должно быть больше нуля");
            }

            while (a % i != 0)
            {             
                i -= 1;            
            }

            return i;
        }

        /// <summary>
        /// 5. Возвращает сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. 
        /// </summary>
        public static int FindSumAllNumbersWhichAreDividedInto7(int a, int b)
        {
            int sum = 0;

            ChangeNumbers(ref a, ref b);

            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        /// <summary>
        /// 6. Возвращает N-ое число ряда фибоначчи.
        /// </summary>
        public static int FindFibonacciNumber(int N)
        {
            if (N <= 0)
            {
                throw new Exception("N < 0. Номер числа должен быть больше нуля.");
            }

            int first = 1;
            int second = 1;
            int tmp = 0;

            if (N <= 2)
            {
                return 1;
            }
            else
            {
                for (int i = 2; i < N; i++)
                {
                    tmp = first + second;
                    first = second;
                    second = tmp;
                }
                return tmp;

            }
        }
        /// <summary>
        /// 7. Возвращает наибольший общий делитель двух чисел, используя алгоритм Евклида.
        /// </summary>
        public static int FindGreatestCommonDivisorOfTwoNumbers(int a, int b)
        {
            if ((a == 0) || (b == 0))
            {
                throw new Exception("a или b равны нулю. Числа должны быть отличные от нуля");
            }

            int tmp;


            if ((a < 0) || (b < 0))
            {
                a = Math.Abs(a);
                b = Math.Abs(b);
            }

            ChangeNumbers(ref b, ref a);

            while (b != 0)
            {
                tmp = b;
                b = a % b;
                a = tmp;
            }
            return a;
        }

        /// <summary>
        /// 8. Пользователь вводит целое положительное число, которое является кубом целого числа N. Найдите число N методом половинного деления.
        /// </summary>
        public static int FindThirdRoot(int N)
        {
            int leftBorder = 0;
            int rightBorder = N;
            int tmp = 0;
            while (tmp * tmp * tmp != N)
            {
                tmp = (leftBorder + rightBorder) / 2;
                if (tmp * tmp * tmp > N)
                {
                    rightBorder = tmp;
                }
                else
                {
                    leftBorder = tmp;
                }
            }
            return tmp;
        }

        /// <summary>
        /// 9. Найти количество нечетных цифр этого числа.
        /// </summary>
        public static int FindCountOfOddNumbers(int N)
        {
            if (N < 0)
            {
                N = Math.Abs(N);
            }
            int count = 0;
            for (int i = N; i != 0; i /= 10)
            {
                if ((i % 10) % 2 == 1)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// 10. Найти число, которое является зеркальным отображением последовательности цифр заданного числа
        /// </summary>
        public static int FindMirrorNumber(int N)
        {
            int tmp = 0;
            for (int i = N; i != 0; i /= 10)
            {
                tmp = tmp * 10 + i % 10;
            }
            return tmp;
        }

        /// <summary>
        /// 11. *Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных.
        /// </summary>
        public static void WriteNumberIfCountOfEvenMoreThanOdd(int N) 
        {
            if (N <= 0)
            {
                throw new Exception("N < 0. Номер числа должен быть больше нуля.");
            }

            int even = 0;
            int odd = 0;
            for (int i = 0; i < N; i++)
            {                
                for (int tmp = i; tmp > 0; tmp /= 10)
                {
                    int tmpCycle = tmp % 10;
                    if (tmpCycle % 2 == 0)
                    {
                        even += tmpCycle;
                    }
                    else
                    {
                        odd += tmpCycle;
                    }
                }
                if (even > odd)
                {
                    Console.WriteLine(i);
                }
                even = 0;
                odd = 0;
            }
        }

        /// <summary>
        /// 12. Сообщите, есть ли в написании двух чисел одинаковые цифры. Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”
        /// </summary>
        public static bool ThereAreTheSameNumbers(int a, int b)
        {
            if ((a < 0) || (b < 0))
            {
                a = Math.Abs(a);
                b = Math.Abs(b);
            }

            while (a != 0)
            {
                int tmp = a % 10;
                for (int i = b; i != 0; i /= 10)
                {
                    if (tmp == i % 10)
                    {
                        return true;
                    }
                }
                a /= 10;
            }
            return false;
        }
    }
}
