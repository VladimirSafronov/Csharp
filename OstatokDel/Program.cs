// Программа выводящая числа, которые делятся на 4 и на 10
int current = 2;
int finish = 128;
int a = 4;
int b = 10;

while(current <= finish)
{
    if(current % a == 0 && current % b == 0)
    Console.WriteLine(current);
    current = current + 1;
}
