//  7. =======Показать числа от -N до N========

int n = 3;

int[] CreateArray( int arg)
{
    int [] arrayA = new int [arg * 2 + 1];  //+1 для того, чтобы влез 0
    for(int i = -arg; i <= arg; i++)
    {
        arrayA[i + arg] = i;
    }
    return arrayA;
}

int[] arr =CreateArray(n);

// for(int count = 0; count < arrayA.Length; count++) Console.Write($"{arrayA[count]} ");
Console.WriteLine(String.Join(',', arr)); //вывод массива на экран через запятую
