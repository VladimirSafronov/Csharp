// 48. Показать двумерный массив размером m×n заполненный целыми числами

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int[,] matrix = FillArray(5,5);
PrintArray(matrix);