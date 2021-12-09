// 24. Найти кубы чисел от 1 до N

double[] FuncPow(int n)
{
    double [] array = new double [n];
    for(int i = 1; i <= n; i++)
    {
        array[i - 1] = Math.Pow(i, 3);
    }
    return array;
}

double [] Cube = FuncPow(10);

Console.WriteLine(String.Join(',', Cube));
