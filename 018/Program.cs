// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool Func18(bool x, bool y)
{
    return (!(x && y) == !x || !y);
}

Console.WriteLine(Func18(false, true));
