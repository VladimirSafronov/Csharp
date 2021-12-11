// 47. Написать программу копирования массива

int[] FillArray (int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

int[] Copy(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++) newArray[i] = array[i];
    return newArray;
}

int[] numbers = FillArray(10);
Console.WriteLine(String.Join(',', numbers));
Console.WriteLine();
int[] numbersCopy = Copy(numbers);
Console.WriteLine(String.Join(',', numbersCopy));