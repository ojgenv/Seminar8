/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2                                                   
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] arr = Generate2DArray(3, 4);
Print2DArray(arr);
Console.WriteLine();
Print2DArray(reverseArray(arr));

int[,] reverseArray(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        int[] row = new int[arr.GetLength(1)];
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            row[i] = arr[j, i];
        }
        Array.Sort(row);
        Array.Reverse(row);
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            arr[j, i] = row[i];
        }
    }
    return arr;
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