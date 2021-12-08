// 11. =========Дано число из отрезка [10, 99]. Показать наибольшую цифру числа=======

int MaxNum(int arg)
{
    int a = arg / 10;
    int b = arg % 10;
    if(a > b) return a;
    else return b;
}

int CreateNum()
{
    return new Random().Next(10, 100);
}

int number = CreateNum();
Console.WriteLine(number);
Console.WriteLine(MaxNum(number));
