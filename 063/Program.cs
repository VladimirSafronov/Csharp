// 63. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы 
// соответствующего элемента

int[,,] FillArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    int[] twoDigitNumbers = Shuffle();
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++) array[i, j, k] = twoDigitNumbers[index++];
        }
    }
    return array;
}

int[] Shuffle()  //создаем массив со случайными неповторяющимися двузначными значениями
{
    int[] array = new int[90];
    for (int i = 10, index = 0; index < array.Length; i++, index++) array[index] = i;
    for (int j = 0; j < array.Length; j++)
    {
        int temporary = array[j];
        int randomIndex = new Random().Next(j, array.Length);  
        array[j] = array[randomIndex];
        array[randomIndex] = temporary;
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++) Console.WriteLine($"index{i},{j},{k}={array[i, j, k]}");
        }
    }
}

int[,,] matrix3D = FillArray(3, 3, 3);
PrintArray(matrix3D);