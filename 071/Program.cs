// 71. Написать программу вычисления функции Аккермана
//m == 0    (n + 1)
//m > 0, n == 0     (A(m - 1, 1))
//m > 0, n > 0     (A(m - 1, A(m, n - 1)))


int AkkermanFunc(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AkkermanFunc(m - 1, 1);
    else return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

Console.WriteLine(AkkermanFunc(4, 1));

