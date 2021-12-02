//69. Показать натуральные числа от M до N, N и M заданы

string ShowNumbers(int m, int n)
{
    if(m == n) return  $" {m}";
    return $" {m + ShowNumbers(m+1, n)}";
}

Console.WriteLine(ShowNumbers(-4, 5));