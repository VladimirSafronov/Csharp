// 62. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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

(int, int) FindLessElement(int[,] array)  //находит первый меньший элемент
{
    int min = array[0, 0];
    int rowIndex = 0;
    int colIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min) 
            {
                min = array[i, j];
                rowIndex = i;
                colIndex = j;
            }
        }
    }
    return (rowIndex, colIndex);
}

int[,] DeleteRowAndCol(int[,] array, int i, int j)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int k = 0, m = 0; k < array.GetLength(0); k++, m++)
    {
        if (k == i) k++;
        for (int l = 0, n = 0; l < array.GetLength(1); l++, n++)
        {
            if (l == j) l++; 
            newArray[m, n] = array[k, l];
        }
    }
    return newArray;
}

int[,] matrix = FillArray(4, 5);
PrintArray(matrix);
Console.WriteLine();
(int rowMinIndex, int colMinIndex) = FindLessElement(matrix);
int[,] newMatrix = DeleteRowAndCol(matrix, rowMinIndex, colMinIndex);
PrintArray(newMatrix);
