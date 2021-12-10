// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] CreateArray()
{
    int[] array = new int[15];
    for(int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 10);
    return array;
}

int[] arrayA = CreateArray();

Console.WriteLine(String.Join(',', arrayA));

int SumOddPosition(int[] array)
{
    int sum = 0;
    for(int count = 0; count < array.Length; count +=2) sum = sum + array[count];
    return sum;
}

Console.WriteLine(SumOddPosition(arrayA));
