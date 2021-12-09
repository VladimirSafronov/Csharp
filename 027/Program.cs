// 27. Определить количество цифр в числе

int FindQuantity(int arg)
{
    arg = Math.Abs(arg);
    int result = 1;
    while(arg > 10) 
    {
        arg = arg / 10;
        result ++;
    }
    return result;
}

Console.WriteLine(FindQuantity(-8641219));
