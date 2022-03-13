using System;

namespace HW_1_3
{
    public static class Arrays
    {       
        /// <summary>
        /// 1. Находит минимальный элемент массива
        /// </summary>
        public static int FindMinElement(int[] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Пустой массив");
            }
            int tmp = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (tmp > array[i])
                {
                    tmp = array[i];
                }
            }
            return tmp;
        }

        /// <summary>
        /// 2. Находит максимальный элемент массива
        /// </summary>
        public static int FindMaxElement(int[] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Пустой массив");
            }
            int tmp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (tmp < array[i])
                {
                    tmp = array[i];
                }
            }
            return tmp;
        }
        /// <summary>
        /// 3. Находит индекс минимального элемента массива
        /// </summary>
        public static int FindIndexOfMinElement(int[] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Пустой массив");
            }
            int tmp = array[0];
            int indx = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (tmp > array[i])
                {
                    tmp = array[i];
                    indx = i;
                }
            }
            return indx;
        }
        /// <summary>
        /// 4. Находит индекс максимального элемента массива
        /// </summary>
        public static int FindIndexOfMaxElement(int[] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Пустой массив");
            }
            int tmp = array[0];
            int indx = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (tmp < array[i])
                {
                    tmp = array[i];
                    indx = i;
                }
            }
            return indx;

        }
        /// <summary>
        /// 5. Вычисляет сумму элементов массива с нечетными индексами
        /// </summary>
        public static int CalculatesTheSumOfElementsWithOddIndices(int[] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Пустой массив");
            }
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        /// <summary>
        /// 6. Возвращает массив в обратном порядке
        /// </summary>
        public static int[] Reverse(int[] array)
        {
            int[] arrayReverse = new int[array.Length];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                arrayReverse[array.Length - i - 1] = array[i];
            }
            return arrayReverse;
        }

        /// <summary>
        /// 7. Возвращает количество нечетных элементов массива
        /// </summary>
        public static int FindCountOfOddNumbers(int[] arr)
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
        public static int[] SwapHalfs(int[] array)
        {
            int[] swappedArray = new int[array.Length];
            Array.Copy(array, swappedArray, array.Length);
            int halfOfLength = array.Length / 2;

            for (int i = 0; i < halfOfLength; i++)
            {
                Variablies.ChangeNumbers(ref swappedArray[i], ref swappedArray[i + halfOfLength + (swappedArray.Length % 2)]);
            }
            return swappedArray;
        }
        /// <summary>
        /// 9. Сортирует массив по возрастанию методом Bubble через for
        /// </summary>
        public static int[] BubbleSortFor(int[] array)
        {
            int[] sortedArray = new int[array.Length];
            Array.Copy(array, sortedArray, array.Length);
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (sortedArray[j] > sortedArray[j + 1])
                    {
                        Variablies.ChangeNumbers(ref sortedArray[j], ref sortedArray[j + 1]);
                    }
                }
            }
            return sortedArray;
        }
        /// <summary>
        /// 9* Сортирует массив по повозрастанию методом Bubble через while и flag
        /// </summary>
        public static int[] BubbleSortWhile(int[] array)
        {
            int[] sortedArray = new int[array.Length];
            Array.Copy(array, sortedArray, array.Length);
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (sortedArray[j] > sortedArray[j + 1])
                    {
                        Variablies.ChangeNumbers(ref sortedArray[j], ref sortedArray[j + 1]);
                        flag = true;
                    }
                }
            }
            return sortedArray;
        }

        /// <summary>
        /// 10. Сортирует массив по убыванию методом Insert 
        /// </summary>
        public static int[] InsertSortReverse(int[] array)
        {
            int[] sortedArray = Arrays.CopyOfArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                int max = i;

                for (int j = 0; j < i + 1; j++)
                {
                    if (sortedArray[j] < sortedArray[max])
                    {
                        max = j;
                    }
                    Variablies.ChangeNumbers(ref sortedArray[i], ref sortedArray[max]);
                }
            }
            return sortedArray;
        }

        /// <summary>
        /// * Сортирует массив по повозрастанию и убыванию методом Select
        /// </summary>
        public static int[] SelectSort(int[] array, bool reverse = false)
        {
            int[] sortedArray = Arrays.CopyOfArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                int cursor = sortedArray[i];
                int position = i;
                while ((position > 0) && (sortedArray[position - 1] > cursor))
                {
                    sortedArray[position] = sortedArray[position - 1];
                    position -= 1;
                }
                sortedArray[position] = cursor;
            }
            if (reverse == true)
            {
                sortedArray = Reverse(sortedArray);
            }
            return sortedArray;
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
