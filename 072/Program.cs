// 72. Написать программу возведения числа А в целую стень B

int Degree(int a, int b)
{
    if(b == 0) return 1;
    return a * Degree(a, b - 1);
}

Console.WriteLine(Degree(3, 3));