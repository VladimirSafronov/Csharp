// 43. Написать программу преобразования десятичного числа в двоичное

// int[] createArr(int arg)
// {
//     int[] array = new int[10];
//     int i = 0;
//     while(arg > 0)
//     {
//         if(arg % 2 == 0) array[i] = 0;
//         else array[i] = 1;
//         i++;
//         arg = arg / 2;
//     }
//     return array;
// }

// int[] ChangeToBinary(int[] array)
// {
//     int last = array.Length -1; int temporary = 0;
//     for(int first = 0; first < array.Length / 2; first++)
//     {
//         temporary = array[first]; 
//         array[first] = array[last];
//         array[last] = temporary;
//         last --;
//     }
//     return array;
// }

// int[] firstArr = ChangeToBinary(createArr(657));
// Console.WriteLine(String.Join(' ', firstArr));

//_________________________

int decimalNum = int.Parse(Console.ReadLine());

int findIndexNumArray(int arg)
{
    int i = 0; 
    while(arg > 0)
    {
        arg = arg/2;
        i++;
    }
    return i;
}

int[] ChangeToBinary(int index, int arg)
{
    int[] array = new int[index];
    int last = array.Length - 1;
    for(int j = 0; j < array.Length; j++)
    {
        if(arg % 2 == 0) array[last] = 0;
        else array[last] = 1;
        arg = arg / 2;
        last -=1;
    }
    return array;
}

int[] binarArray = ChangeToBinary(findIndexNumArray(decimalNum), decimalNum);
Console.WriteLine(String.Join(' ', binarArray));
