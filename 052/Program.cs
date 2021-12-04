// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int[,] FillArray(int a, int b)
{
    int[,] array = new int[a,b];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(2,9);
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

int[,] ChangeEvenIndex(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i != 0 && j != 0 && i % 2 == 0 && j % 2 == 0) array[i, j] = array[i, j] * array[i, j];
        }
    }
    return array;
}

int[,] matrix = FillArray(5, 5);
PrintArray(matrix);
Console.WriteLine();
int[,] newMatrix = ChangeEvenIndex(matrix);
PrintArray(newMatrix);