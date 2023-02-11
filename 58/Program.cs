/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int[,] arr1 = Generate2DArray(4, 2);
Print2DArray(arr1);
Console.WriteLine();
int[,] arr2 = Generate2DArray(2, 3);
Print2DArray(arr2);


int[,] arrMul = MultiplyArray(arr1, arr2);
Console.WriteLine();
Print2DArray(arrMul);

int[,] MultiplyArray(int[,] A, int[,] B)
{
    int [,] C = new int[A.GetLength(0),B.GetLength(1)];
    for (int i = 0; i < C.GetLength(0); i++)
    {
        for (int j = 0; j < C.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < B.GetLength(0); k++)
            {
                sum = sum + A[i, k] * B[k, j];
            }
            C[i, j] = sum; 
        }
    }
    return C;
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