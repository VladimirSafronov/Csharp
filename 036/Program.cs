// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] CreateArray()
{
    int[] array = new int [15];
    for(int i = 0; i < array.Length; i++) array[i] = new Random().Next(100, 1000);
    return array;
}

(int a, int b) FindOddEven(int[] array)
{
    int odd = 0; int even = 0;
    for(int k = 0; k < array.Length; k++)
    {
        if(array[k] % 2 != 0) odd +=1;
        else even +=1;
    }
    return (odd, even);
}

int[] RandomArray = CreateArray();
Console.WriteLine(String.Join(',', RandomArray));
Console.WriteLine(FindOddEven(RandomArray));   //показывает нечетные, затем четные.
