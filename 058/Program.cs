// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно

int[,] FillArray(int row, int col)
{
    int[,] array = new int[row, col];
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

int[,] RowColReplace(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++) newArray[j, i] = array[i, j];
        }
        return newArray;
    }
    else 
    {
        Console.WriteLine("Количество строк и столбцов не совпадают");
        return array;
    }
}

int[,] matrix = FillArray(4, 3);
PrintArray(matrix);
Console.WriteLine();
int[,] newMatrix = RowColReplace(matrix);
PrintArray(newMatrix);