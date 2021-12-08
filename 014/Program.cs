// 14. Найти третью цифру числа или сообщить, что её нет

int RandomNum()
{
    return new Random().Next(-150, 150);
}

int number = RandomNum();
Console.WriteLine(number);

int FindHundredNum(int arg)
{
    if(arg / 100 != 0) 
    {
        arg = arg /100 % 10;
        if(arg < 0) return arg * -1;    //выводит только положительные цифры
        else return arg;
    }
    else return -1;  //вывод -1 означает, что третьей цифры нет
}

Console.WriteLine(FindHundredNum(1357));

int FindThirdNum(int arg)
{
    arg = Math.Abs(arg);
    if(arg / 100 == 0) return -1;
    else 
    {
        while(arg / 100 > 9) arg = arg / 10;
        return arg % 10;
    }
}
Console.WriteLine(FindThirdNum(-56854802));
