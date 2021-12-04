// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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

double[] ArithmeticMeanColumn(int[,] array)
{
    double[] arithmeticMean = new double[array.GetLength(1)];
    for(int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++) arithmeticMean[i] = arithmeticMean[i] + array[j, i];
        arithmeticMean[i] /= array.GetLength(0);
    }
    return arithmeticMean;
}

int[,] matrix = FillArray(3, 5);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine(String.Join('|', ArithmeticMeanColumn(matrix)));