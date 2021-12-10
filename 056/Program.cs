// 56. Написать программу, которая обменивает элементы первой строки и последней строки

int[,] FillArray(int a, int b)
{
    int[,] array = new int[a,b];
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

int[,] ReplaceFirstAndLastString(int[,] array)
{
    int[] temporary = new int[array.GetLength(1)];
    for(int i = 0; i < array.GetLength(1); i++) 
    {
        temporary[i] = array[0, i];   //Вношу во временный массив первую строку. 
        array[0, i] = array[array.GetLength(0) - 1, i]; //Переношу значения с последней строки в первую.
        array[array.GetLength(0) - 1, i] = temporary[i]; //из временного в последнюю строку
    }
    return array; 
}

int[,] matrix = FillArray(6, 8);
PrintArray(matrix);
Console.WriteLine();
int[,] newMatrix = ReplaceFirstAndLastString(matrix);
PrintArray(newMatrix);
