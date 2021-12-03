// 49. Показать двумерный массив размером m×n заполненный вещественными числами

double[,] FillArray(int m, int n)
{
    double[,] array = new double[m, n];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().NextDouble();
    }
    return array;
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

double[,] matrix = FillArray(4, 4);
PrintArray(matrix);