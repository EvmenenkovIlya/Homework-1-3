using HW_1_3;



int[] a = Arrays.GenerateArray(10);
Arrays.PrintArray(a);

int[] tmp = new int[a.Length];
Array.Copy(a, tmp, a.Length);


Console.WriteLine("1 Task");
Console.WriteLine(Arrays.FindMinOfArray(a));

Console.WriteLine("2 Task");
Console.WriteLine(Arrays.FindMaxOfArray(a));

Console.WriteLine("3 Task");
Console.WriteLine(Arrays.FindIndexOfMinInArray(a));

Console.WriteLine("4 Task");
Console.WriteLine(Arrays.FindIndexOfMaxInArray(a));

Console.WriteLine("5 Task");
Console.WriteLine(Arrays.CalculatesTheSumOfElementsWithOddIndices(a));

Console.WriteLine("6 Task");
Arrays.PrintArray(Arrays.ReverseArray(a));

Console.WriteLine("7 Task");
Console.WriteLine(Arrays.FindCountOfOddNumbersInArray(a));

Console.WriteLine("8 Task");
Arrays.PrintArray(Arrays.SwapHalfsOfArray(a));


Console.WriteLine("9 Task Bubble Sort For");
Arrays.PrintArray(Arrays.BubbleSortFor(tmp));

Array.Copy(a, tmp, a.Length);
Console.WriteLine("9* Task Bubble Sort For");
Arrays.PrintArray(Arrays.BubbleSortWhile(tmp));

Array.Copy(a, tmp, a.Length);
Console.WriteLine("10 Task Insert Sort Reverse");
Arrays.PrintArray(Arrays.InsertSortReverse(tmp));

Array.Copy(a, tmp, a.Length);
Console.WriteLine("Select Sort");
Arrays.PrintArray(Arrays.SelectSort(tmp, true));

Arrays.PrintArray(BranchStructuries.SortByIncrease(3, 7, 1));

Arrays.PrintArray(Cycles.WriteNumberIfCountOfEvenMoreThanOdd(100));
