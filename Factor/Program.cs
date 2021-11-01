// Простые множители 13195: 5, 7, 13 и 29
//Какой самый большой простой делитель числа 600851475143?

long number = 600851475143; 
int factor = 2; 
int stopNum = 1;
while(number != stopNum)
{
    if(number % factor == 0)
    {
        number = number / factor;
    }
    else
    {
        factor++;
    }
}


Console.WriteLine($"самый большой простой делитель = {factor}");