// 12. ======Удалить вторую цифру трёхзначного числа=========

int DeleteSecNumber(int arg)
{
    int a = arg / 100;
    int b = arg % 10;
    return a * 10 + b;
}
Console.WriteLine(DeleteSecNumber(-341));
