// 50. В двумерном массиве n×k заменить четные элементы на противоположные

int[,] FillArray(int n, int k)
{
    int[,] array = new int[n, k];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(0, 9);
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

int[,] ReplaceEvenElement(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) 
        {
            if(array[i, j] % 2 == 0) array[i, j] = array[i, j] * -1;
        }
    }
    return array;
}

int[,] matrix = FillArray(3, 5);
PrintArray(matrix);
Console.WriteLine();
int[,] matrixWithNegative = ReplaceEvenElement(matrix);
PrintArray(matrixWithNegative);