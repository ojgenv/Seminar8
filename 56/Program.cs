/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] arr = Generate2DArray(3, 4);
Print2DArray(arr);
int[] sumsArr = sumsArray(arr);
Console.WriteLine();
PrintArray(sumsArr);
Console.WriteLine();
Console.WriteLine(FindMin(sumsArr));


int[] sumsArray(int[,] arr)
{
    int[] sums = new int[arr.GetLength(0)];
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        sums[j] = 0;
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            sums[j] += arr[j, i];
        }
    }
    return sums;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"{arr[i]} ");
    }
}

int FindMin(int[] arr)
{
    int min = arr[0];
    int minIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
            minIndex = i;
        }
    }
    return minIndex + 1;
}

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void Print2DArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}