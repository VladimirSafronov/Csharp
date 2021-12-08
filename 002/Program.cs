//  2. Даны два числа. Показать большее и меньшее число

int CreateNum()
{
    return new Random().Next(1, 100);
}

int a = CreateNum();
int b = CreateNum();

int Max(int first, int second)
{
    if (first > second) return first;
    else return second;
}

int Min(int fir, int sec)
{
    if (fir < sec) return fir;
    else return sec;
}

int high = Max(a, b);
int low = Min(a, b);

Console.WriteLine($"Большее число {high}");
Console.WriteLine($"Меньшее число {low}");
// __________________
// //верхние методы сокращаются до показаных снизу, которые можно соединить в один
// int Max2(int first, int second) => first > second ? first : second;
// int Min2(int fir, int sec) => fir < sec ? fir : sec;

// (int min, int max) MinMax(int f, int s) => f > s ? (f, s) : (s, f);
