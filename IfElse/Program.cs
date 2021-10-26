// Программа, выводящая на экран максимальное число

int a = new Random().Next(1, 100);
int b = new Random().Next(1, 100);  // Говорим программе генерировать числа
Console.WriteLine($"a = {a} b = {b}");  // Говорим показывать сгенерированные числа
if (a > b)
{
    Console.WriteLine(a);
}

else
{
    Console.WriteLine(b);
}