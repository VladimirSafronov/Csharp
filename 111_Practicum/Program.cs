// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. Создать на его основе масив B, отбрасывая те, 
//которые нарушают порядок:
// - возрастания
// - элементы, больше 8
// - знакочередования

int number = 10;
int [] A = new int [number];
int index = 0;
while(index < number)
{
    A [index] = new Random().Next(-50, 50);
    index++;
}

index = 0;
while(index < number)
{
    Console.WriteLine(A[index]);
    index++;
}
//===========создает массив В, в порядке возрастания чисел=========================
// index = 1;
// Console.WriteLine();
// int maxEl = A[0];
// Console.WriteLine(maxEl);
// while(index < number)
// {
//     if(A[index] > maxEl)
//     {
//         maxEl = A[index];
//         Console.WriteLine(maxEl);
//     }
//     index++;
// }
//=========создает массив В, отбрасывая элементы более 8=========

// index = 0;
// int criticalNumber = 8;
// Console.WriteLine();
// while(index < number)
// {
//     if(A[index] <= criticalNumber)
//     {
//         Console.WriteLine(A[index]);
//     }
//     index++;
// }
//=======создает массив В со знакочередованием===================

index = 0;
Console.WriteLine();
Console.WriteLine(A[index]);
while(index < number - 1)
{
    if(A[index] >= 0)
    {
        index++;
        if(A[index] <= 0)
        {
            Console.WriteLine(A[index]);
        }
    }
    else
    {
        index++;
        if(A[index] >= 0)
        {
            Console.WriteLine(A[index]);
        }
    }
}