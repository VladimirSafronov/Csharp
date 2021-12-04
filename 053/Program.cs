// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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

List<int> ShowIndex(int[,] array, int number)
{
    List<int> col = new();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == number) 
            {
                col.Add(i); 
                col.Add(j);
            }
        }
    }
    if(col.Count == 0) Console.WriteLine("Такого элемента нет");
    return col;  // выводит индекс числа в массиве (сначала i, потом j)
}



int[,] matrix = FillArray(5, 5);
PrintArray(matrix);
Console.WriteLine();
List<int> index = ShowIndex(matrix, 7);
Console.WriteLine(String.Join(',', index));