// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. Создать на его основе масив B, отбрасывая те, 
//которые нарушают порядок:
// - возрастания
// - элементы, больше 8
// - знакочередования

// int number = 10;
// int [] A = new int [number];
// int index = 0;
// while(index < number)
// {
//     A [index] = new Random().Next(-50, 50);
//     index++;
// }

// index = 0;
// while(index < number)
// {
//     Console.WriteLine(A[index]);
//     index++;
// }
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

// index = 0;
// Console.WriteLine();
// Console.WriteLine(A[index]);
// while(index < number - 1)
// {
//     if(A[index] >= 0)
//     {
//         index++;
//         if(A[index] <= 0)
//         {
//             Console.WriteLine(A[index]);
//         }
//     }
//     else
//     {
//         index++;
//         if(A[index] >= 0)
//         {
//             Console.WriteLine(A[index]);
//         }
//     }
// }

//=======А ТЕПЕРЬ ПРИ ПОМОЩИ МЕТЕДОВ===========

void CreateArray(int [] array)
{
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        array[index] = new Random().Next(-49, 50);
        index++;
    }
}

void PrintArray(int [] arr)
{
    int dist = arr.Length;
    int ind = 0;
    while(ind < dist)
    {
        Console.WriteLine(arr[ind]);
        ind ++;
    }
}

int [] arrayA = new int [10];

CreateArray(arrayA);
PrintArray(arrayA);
Console.WriteLine();

//=====================================
// void CreateArrayB(int [] increase)
// {
//     int maxEl = arrayA[0];
//     Console.WriteLine(maxEl);
//     int count = 1;
//     int way = arrayA.Length;
//     while(count < way)
//     {
//         if(arrayA[count] > maxEl)
//         {
//             maxEl = arrayA[count];
//             Console.WriteLine(maxEl);
//         }
//         count++;
//     }
// }
// int [] arrayB = new int [10];
// CreateArrayB(arrayB);
// PrintArray(arrayB);
//======================================

// int [] arrayB = new int [10];
// void CreateArrB(int [] critical)
// {
//     int criticalNum = 8;
//     int count = 0;
//     int countB = 0;
//     int road = arrayA.Length;
//     while(count < road)
//     {
//         if(arrayA[count] < criticalNum)
//         {
//             arrayB[countB] = arrayA[count];
//             countB++;
//         }
//         count++;
//     }
// }
// CreateArrB(arrayB);
// PrintArray(arrayB);

//========================================

bool IsCurrentNumberPositive(int currentNumber)
{
    return currentNumber >= 0;
}

int [] arrayB = new int [arrayA.Length];

int countA = 0;
int countB = 0;
bool isNextNumberPositive;
isNextNumberPositive = !IsCurrentNumberPositive(arrayA[countA]);
arrayB[countB] = arrayA[countA];
countA++;
countB++;
while(countA < arrayA.Length)
{
    if(isNextNumberPositive == IsCurrentNumberPositive(arrayA[countA]))
    {
        arrayB[countB] = arrayA[countA];
        countA++;
        countB++;
        isNextNumberPositive = !isNextNumberPositive;
    }
    else
    {
        countA++;
    }

}

PrintArray(arrayB);

// последняя задача была написана при помощи друга. Идея такая была, но точно бы не смог сам ее реализовать.