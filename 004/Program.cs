//  4. Найти максимальное из трех чисел

int FindMaxNumber(int x, int y, int z)
{
    int max = x;
    if(y > max) max = y;
    if(z > max) max = z;
    return max;
}

int CreateNum()
{
    return new Random().Next(1, 100);
}

int a = CreateNum();
Console.Write($"{a} ");
int b = CreateNum();
Console.Write($"{b} ");
int c = CreateNum();
Console.WriteLine(c);

Console.WriteLine($"Максимальное число {FindMaxNumber(a, b, c)}");
