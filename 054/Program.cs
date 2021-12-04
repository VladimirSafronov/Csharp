// 54. В матрице чисел найти сумму элементов главной диагонали

int[,] FillArray(int a)
{
    int[,] array = new int[a,a];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(0,9);
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

int SumMainMatrixDiagonal(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)  sum = sum + array[i, i];
    return sum;
}

int[,] matrix = FillArray(6);
PrintArray(matrix);
Console.WriteLine(SumMainMatrixDiagonal(matrix));