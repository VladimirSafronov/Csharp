// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива

int[] CreateArr()
{
    int[] array = new int [12];
    for(int i = 0; i < array.Length; i++) array[i] = new Random().Next(-9, 10);
    return array;
}

(int pos, int neg) FindSumPositiveAndNegativeNum(int[] array)
{
    int positiveTotal = 0;
    int negativeTotal = 0;
    for(int i = 0; i < array.Length; i++) 
    if(array[i] > 0) positiveTotal = positiveTotal + array[i];
    else negativeTotal = negativeTotal + array[i];
    return (positiveTotal, negativeTotal);
}

int[] Array9 = CreateArr();
Console.WriteLine(String.Join(',', Array9));
Console.WriteLine();
Console.WriteLine(FindSumPositiveAndNegativeNum(Array9));
