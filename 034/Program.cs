// 34. Написать программу замену элементов массива на противоположные

int[] Array = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

int[] ChangeArrayElement(int[] array)
{
    int temporary = 0; int rear = array.Length - 1;
    for(int front = 0; front < array.Length/2; front++) //дохожу до середины массива
    {
        temporary = array[front];
        array[front] = array[rear];
        array[rear] = temporary;
        rear --;
    }
    return array;
}

int[] RearArray = ChangeArrayElement(Array);

Console.WriteLine(String.Join('|', RearArray));
