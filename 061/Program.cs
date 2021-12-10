// 61. Найти произведение двух матриц

int[,] FillArray(int a, int b)
{
    int[,] array = new int[a,b];
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

int[,] MultiplicationArray(int[,] firstArray, int[,] secondArray)
{
    int[,] multArr = new int[firstArray.GetLength(0), firstArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < firstArray.GetLength(1); j++) multArr[i, j] = firstArray[i, j] * secondArray[i, j];
    }
    return multArr;
}

int[,] firstMatrix = FillArray(4, 4);
int[,] secondMatrix = FillArray(4, 4);
PrintArray(firstMatrix);
Console.WriteLine();
PrintArray(secondMatrix);
Console.WriteLine();
int[,] multiplicationMatrix = MultiplicationArray(firstMatrix, secondMatrix);
PrintArray(multiplicationMatrix);