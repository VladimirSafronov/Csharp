// 17. =====По двум заданным числам проверять является ли одно квадратом другого

bool Func17(int a, int b)
{
    if (a == b * b || b == a * a ) return true;
    else return false;
}

Console.WriteLine(Func17(26, 5));
