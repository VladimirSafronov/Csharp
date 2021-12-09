// 26. Возведите число А в натуральную степень B используя цикл

double a = 1.13;
int b = 5;

double FuncPow(double argA, int argB)
{
    double result = argA;
    for(int i = 1; i < argB; i++) result = result * argA;
    return result;
}
Console.WriteLine(FuncPow(a, b));
