// 31. Задать массив из 8 элементов и вывести их на экран 

string[] week = { "Дни недели:", " пн", " вт", " ср", " чт", " пт", " сб", " вс" };

void PrintArray(string[] arr)
{
    for (int i = 0; i < 8; i++) Console.Write(arr[i]);
}

PrintArray(week);

Console.WriteLine(String.Join(',', week)); //упрощенный вывод массива
