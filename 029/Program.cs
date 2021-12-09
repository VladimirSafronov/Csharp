// 29. Написать программу вычисления произведения чисел от 1 до N

int n = 10;
int MultiplicationNumFrom1(int arg)
{
    int result = 1;
    for(int i = 1; i <= arg; i++) result = result * i;
    return result;
}
Console.WriteLine(MultiplicationNumFrom1(n));
