/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] arr = Generate3DArray(2, 2, 2);
Print3DArray(arr);

int[,,] Generate3DArray(int m, int n, int p)
{
    int count = 0;
    int[,,] result = new int[m, n, p];
    int[] nums = new int[m * n * p];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = new Random().Next(10, 100);   
                while (Array.IndexOf(nums, result[i, j, k]) != -1)
                {
                    result[i, j, k] = new Random().Next(10, 100);
                }
                nums[count] = result[i, j, k];
                count++;
            }
        }
    }
    return result;
}

void Print3DArray(int[,,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]} ({i}, {j}, {k}) ");  
            }
            Console.WriteLine();
        }
    }
}