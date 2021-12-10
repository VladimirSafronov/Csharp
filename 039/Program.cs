// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] CreateArray()
{
    int[] array = new int [10];
    for(int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 10);
    return array;
}

int[] multiplicationPairs(int[] array)
{
    int rear = array.Length -1;
    int[] multPairs = new int[array.Length / 2];  //при нечетной длинне массива, средний элемент теряется, т.к. для него нет пары
    for(int count = 0; count < multPairs.Length; count++) 
    {
        multPairs[count] = array[count] * array [rear];
        rear--;
    }
    return multPairs;
}

int[] arrayA = CreateArray();
Console.WriteLine(String.Join(',', arrayA));
int[] arrayB = multiplicationPairs(arrayA);
Console.WriteLine(String.Join(',', arrayB));
