using HW_1_3;



int[] a = Arrays.GenerateArray();
Arrays.PrintArray(a);

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