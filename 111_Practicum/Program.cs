// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. Создать на его основе масив B, отбрасывая те, которые нарушают порядок
// - возрастания
// - элементы, больше 50
// - знакочередования


// int GetRandom = (int minValue, int maxValue)
// {
//     return new Random().Next(minValue, maxValue);
// }   - вспомогательная подпрограмма. Можно заменить 16 строку.

int number = 10;
int [] A = new int [number];
int index = 0;
while(index < number)
{
    A [index] = new Random().Next(10, 100);
    index++;
}

index = 0;
while(index < number)
{
    Console.WriteLine(A[index]);
    index++;
}
//====================================
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
//====================================

index = 0;
int criticalNumber = 50;
Console.WriteLine();
while(index < number)
{
    if(A[index] <= criticalNumber)
    {
        Console.WriteLine(A[index]);
    }
    index++;
}