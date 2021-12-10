// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] MakeArray()
{
    int[] array = new int [123];
    for(int i = 0; i < array.Length; i++) array[i] = i;
    return array;
}

int Find00(int[] array)
{
    int number = 0;
    for(int count = 0; count < array.Length; count++) 
    {
        if(array[count] / 10 > 0 && array[count] / 10 < 10) number +=1;
    }
    return number;
}

int[] arrayA = MakeArray();
Console.WriteLine(Find00(arrayA));
