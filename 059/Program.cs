// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

int[] StringSum(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sum[i] += array[i, j];
    }
    return sum;
}

int FindLessStringSum(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) 
        {
            min = array[i];
            minIndex = i;
        }
    }
    return minIndex + 1; //выведет номер строки
}

int[,] matrix = FillArray(6, 10);
PrintArray(matrix);
Console.WriteLine();
int[] strSum = StringSum(matrix);
Console.WriteLine(String.Join(',', strSum));
Console.WriteLine($"Меньшая сумма чисел в {FindLessStringSum(strSum)} строке");