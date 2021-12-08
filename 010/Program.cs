// 10. =========Показать вторую цифру трёхзначного числа========

int SecNumber(int arg)
{
    if(arg < 0) arg = arg * -1;
    return arg / 10 % 10;
}

Console.WriteLine(SecNumber(735));
