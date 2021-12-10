// 60. Составить частотный словарь элементов двумерного массива

int[,] FillArray(int n, int k, int minValue, int maxValue)
{
    int[,] array = new int[n, k];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(minValue, maxValue + 1);
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

int[] FrequencyDictionary(int[,] array, int n)  //отдает массив, который содержит количество цифр в двумерном массиве. Индекс равен цифре.
{
    int[] dictionary = new int[n];
    for (int i = 0; i < n; i++)  //будет перебирать массив под каждый символ заново
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[j, k] == i) dictionary[i] += 1;
            }
        }
    }
    return dictionary;
}

int minValue = 0;
int maxValue = 9;
int characters = maxValue - minValue + 1;  //определяет количество символов

int[,] matrix = FillArray(3, 5, minValue, maxValue);
PrintArray(matrix);
Console.WriteLine();
int[] symbolRate = FrequencyDictionary(matrix, characters);
Console.WriteLine(String.Join(',', symbolRate));