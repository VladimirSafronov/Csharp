// 66. Показать натуральные числа от 1 до N, N задано

string ShowNumbers(int n)
{
    if(n == 1) return $"{n} ";
    return $"{ShowNumbers(n-1) + n} ";
}

Console.WriteLine(ShowNumbers(5));