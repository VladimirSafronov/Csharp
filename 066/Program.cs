// 66. Показать натуральные числа от 1 до N, N задано

string ShowNumbers(int n)
{
    if(n == 1) return $" {1}";
    return $" {n + ShowNumbers(n - 1)}";
}

Console.WriteLine(ShowNumbers(10));