//  1. По двум заданным числам проверять является ли первое квадратом второго

bool Func1(int x, int y)
{
    return x == y * y;
}
Console.WriteLine(Func1(26, 5));