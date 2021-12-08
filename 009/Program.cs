//  9. =====Показать последнюю цифру трёхзначного числа======

int LastNumber(int arg)
{
    if(arg < 0) arg = arg * -1;
    return arg % 10;
}
Console.WriteLine(LastNumber(349));
