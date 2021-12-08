// 15. =========Дано число. Проверить кратно ли оно 7 и 23

bool Number(int num)
{
    if(num % 7 == 0 && num % 23 == 0) return true;
    else return false;
}

Console.WriteLine(Number(161));
