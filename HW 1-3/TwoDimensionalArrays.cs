using System;

namespace HW_1_3
{
    static class TwoDimensionalArrays
    {
        /// <summary>
        /// 1. Находит минимальный элемент массива
        /// </summary>
        public static int FindMinOfArray(int[,] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Пустой массив");
            }
            int min = array[0,0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                    }            
                }
            }
            return min;
        }
        /// <summary>
        /// 2. Находит максимальный элемент массива
        /// </summary>
        public static int FindMaxOfArray(int[,] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Пустой массив");
            }
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }

        /// <summary>
        /// 3. Находит индекс минимального элемента массива
        /// </summary>
        public static int[] FindIndexOfMin(int[,] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Пустой массив");
            }
            int min = array[0, 0];
            int[] index = new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                        index[0] = i;
                        index[1] = j;
                    }
                }
            }
            return index;
        }

        /// <summary>
        /// 4. Находит индекс максимального элемента массива
        /// </summary>
        public static int[] FindIndexOfMax(int[,] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Пустой массив");
            }
            int max = array[0, 0];
            int[] index = new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                        index[0] = i;
                        index[1] = j;
                    }
                }
            }
            return index;
        }

        /// <summary>
        /// 5. Находит количество элементов массива, которые больше всех своих соседей одновременно
        /// </summary>
        public static int FindCountElementsHigherThanNeigbors(int[,] array)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i == 0 || array[i, j] > array[i - 1, j])
                        && (i == array.GetLength(0) - 1 || array[i, j] > array[i + 1, j])
                        && (j == 0 || array[i, j] > array[i, j - 1])
                        && (j == array.GetLength(1) - 1 || array[i, j] > array[i, j + 1]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        /// <summary>
        /// 6. Отражает массив относительно его главной диагонали(на вход приходит квадрат)
        /// </summary>
        public static int[,] MirroredAlongTheMainDiagonal(int[,] array)
        {
            int lenth = array.GetLength(0);
            int[,] result = ReturnCopy(array);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Variablies.ChangeNumbers(ref array[i, j], ref array[j,i]);
                }
            }
            return result;
        }

        public static int [,] ReturnCopy(int[,] array)
        {
            int column = array.GetLength(0);
            int line = array.GetLength(1);
            int[,] result = new int[column, line];
            result = (int[,])array.Clone();
            return result;
        }

        public static int[,] GenerateRandomArray(int column, int line, int min = -100, int max = 100)
        {
            Random rand = new Random();
            int[,] array = new int[column, line];
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < line; j++)
                {
                    array[i, j] = rand.Next(min, max + 1); ;
                }                
            }
            return array;
        }
        public static void WriteArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    int freeSpace = 4 - array[i, j].ToString().Length;
                    for (int k = 0; k < freeSpace; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }         
        }
    }
}
