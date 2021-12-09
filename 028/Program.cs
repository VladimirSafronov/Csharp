// 28. Подсчитать сумму цифр в числе

int SumNumbers(int num)
{
    int total = 0;
    num = Math.Abs(num);
    while(num != 0)
    {
        total = total + num % 10;
        num = num / 10;
    }
    return total;
}

Console.WriteLine(SumNumbers(1135));
