using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1_3
{
    internal class Arrays
    {
        public static int[] GenerateArray()
        {           
            Random rand = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            { 
            arr[i] = rand.Next(-100, 101);
            }
            return arr;       
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 1. Находит минимальный элемент массива
        /// </summary>
        public static int FindMinOfArray(int[] arr)
        {
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

    }
}
