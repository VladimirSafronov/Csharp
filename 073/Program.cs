// 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем.

string FirstTwoNumbersSum(int a, int b, int n)
{
    if (a > n) return "";
    else return $" {a + FirstTwoNumbersSum(b, b + a, n)}";
}

Console.WriteLine(FirstTwoNumbersSum(1, 2, 160));