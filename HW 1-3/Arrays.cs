using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1_3
{
    static class Arrays
    {       
        /// <summary>
        /// 1. Находит минимальный элемент массива
        /// </summary>
        public static int FindMinOfArray(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("Пустой массив");
            }
            int tmp = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (tmp > arr[i])
                {
                    tmp = arr[i];
                }
            }
            return tmp;
        }

        /// <summary>
        /// 2. Находит максимальный элемент массива
        /// </summary>
        public static int FindMaxOfArray(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("Пустой массив");
            }
            int tmp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (tmp < arr[i])
                {
                    tmp = arr[i];
                }
            }
            return tmp;
        }
        /// <summary>
        /// 3. Находит индекс минимального элемента массива
        /// </summary>
        public static int FindIndexOfMinInArray(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("Пустой массив");
            }
            int tmp = 0;
            int indx = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (tmp > arr[i])
                {
                    tmp = arr[i];
                    indx = i;
                }
            }
            return indx;
        }
        /// <summary>
        /// 4. Находит индекс максимального элемента массива
        /// </summary>
        public static int FindIndexOfMaxInArray(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("Пустой массив");
            }
            int tmp = 0;
            int indx = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (tmp < arr[i])
                {
                    tmp = arr[i];
                    indx = i;
                }
            }
            return indx;

        }
        /// <summary>
        /// 5. Вычисляет сумму элементов массива с нечетными индексами
        /// </summary>
        public static int CalculatesTheSumOfElementsWithOddIndices(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        /// <summary>
        /// 6. Возвращает массив в обратном порядке
        /// </summary>
        public static int[] ReverseArray(int[] arr)
        {
            int[] arrReverse = new int[arr.Length];
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                arrReverse[arr.Length - i - 1] = arr[i];
            }
            return arrReverse;
        }

        /// <summary>
        /// 7. Возвращает количество нечетных элементов массива
        /// </summary>
        public static int FindCountOfOddNumbersInArray(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) % 2 == 1)
                {
                    count += 1;
                }
            }
            return count;
        }

        /// <summary>
        /// 8. Меняет местами первую и вторую половину массива (1234, результат 3412,  или для 12345 - 45312)
        /// </summary>
        public static int[] SwapHalfsOfArray(int[] arr)
        {
            int[] swappedArr = new int[arr.Length];
            int halfOfLength = arr.Length / 2;
            int tmp;

            for (int i = 0; i < halfOfLength; i++)
            {
                Cycles.ChangeNumbers(ref arr[i], ref arr[i + halfOfLength + (arr.Length % 2)]);
            }
            return arr;
        }
        /// <summary>
        /// 9. Сортирует массив по возрастанию методом Bubble через for
        /// </summary>
        public static int[] BubbleSortFor(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {

                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Cycles.ChangeNumbers(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
            return arr;
        }
        /// <summary>
        /// 9* Сортирует массив по повозрастанию методом Bubble через while и flag
        /// </summary>
        public static int[] BubbleSortWhile(int[] arr)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Cycles.ChangeNumbers(ref arr[j], ref arr[j + 1]);
                        flag = true;
                    }
                }
            }
            return arr;
        }

        /// <summary>
        /// 10. Сортирует массив по убыванию методом Insert 
        /// </summary>
        public static int[] InsertSortReverse(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int max = i;

                for (int j = 0; j < i + 1; j++)
                {
                    if (arr[j] < arr[max])
                    {
                        max = j;
                    }
                    Cycles.ChangeNumbers(ref arr[i], ref arr[max]);
                }
            }
            return arr;
        }

        /// <summary>
        /// * Сортирует массив по повозрастанию и убыванию методом Select
        /// </summary>
        public static int[] SelectSort(int[] arr, bool reverse = false)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int cursor = arr[i];
                int position = i;
                while ((position > 0) && (arr[position - 1] > cursor))
                {
                    arr[position] = arr[position - 1];
                    position -= 1;
                }
                arr[position] = cursor;
            }
            if (reverse == true)
            {
                arr = ReverseArray(arr);
            }
            return arr;
        }

        public static int[] CopyOfArray(int[] arr)
        {
            int[] tmp = new int[arr.Length];
            Array.Copy(arr, tmp, arr.Length);
            return tmp;
        }

        public static int[] GenerateArray(int length, int min = -100, int max = 100)
        {
            Random rand = new Random();
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(min, max + 1);
            }

            return array;
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}
