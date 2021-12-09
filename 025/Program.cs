// 25. Найти сумму чисел от 1 до А

double a = 1000;
double SumNumbersFrom1(double arg)
{
    double result = 0;
    for(double i = 1; i <= arg; i++) result = result + i;
    return result;
}
double res = SumNumbersFrom1(a);
DateTime dt = DateTime.Now;
Console.WriteLine(res);
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
// //__________________________
// int SumNumbers2(int arg)
// {
//     return (arg * (arg + 1)) / 2;  //формула, сильно ускоряющая работу метода
// }
// dt = DateTime.Now;
// Console.WriteLine(SumNumbers2(a));
// Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
