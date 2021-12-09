// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерного массива.

int[,] FillArray(int a, int b)
{
    int[,] array = new int[a, b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(0, 9);
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int[] SelectionSort(int[] array) //метод сортировки выбором по убыванию
{
    int temporary;
    for (int i = 0; i < array.Length; i++)
    {
        int max = array[i];
        int maxIndex = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > max) 
            {
                max = array[j];
                maxIndex = j;
            }
        }
        temporary = array[i];
        array[i] = max;
        array[maxIndex] = temporary; 
    }
    return array;
}

int[,] SortMultidimensional(int[,] array)  //метод сортировки двумерного массива
{
    int[] stringArray = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) stringArray[j] = array[i, j];
        
        stringArray = SelectionSort(stringArray);

        for (int k = 0; k < array.GetLength(1); k++) array[i, k] = stringArray[k];
    }
    return array;
}

int[,] matrix = FillArray(3, 7);
PrintArray(matrix);
Console.WriteLine();
int[,] sortMatrix = SortMultidimensional(matrix);
PrintArray(sortMatrix);
