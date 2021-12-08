// 13. =======Выяснить, кратно ли число заданному, если нет, вывести остаток.=======

int CreateNum()
{
    return new Random().Next(10, 100);
}

int CreateDev()
{
    return new Random().Next(2, 10);
}

int firstNum = CreateNum();
int secondNum = CreateDev();
Console.Write($"{firstNum} {secondNum}");
Console.WriteLine();

int Multiple(int a, int b)
{
    if(a % b == 0) return -1;   //в случае кратности чисел выведет -1
    else return firstNum % secondNum;
}

Console.WriteLine(Multiple(firstNum, secondNum));
