//  8. =========Показать четные числа от 1 до N=========

int [] arrayA = new int [10];
int n = 21;

int [] CreateArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, n + 1);
    }
    return array;
}

CreateArray(arrayA);

for(int ind = 0; ind < arrayA.Length; ind++) Console.Write($"{arrayA[ind]} ");

Console.WriteLine();

int[] honest(int[] array)
{
    int count = 0;
    for(int index = 0; index < arrayA.Length; index++) if(arrayA[index] % 2 == 0) count++;
    int[] arr = new int[count];
    count = 0;
    int l = 0;
    while(l < arrayA.Length) 
    {
        if(arrayA[l] % 2 == 0) 
        {
            arr[count] = arrayA[l];
            count++;
            l++;
        }
        else l++;
    }
    return arr;
}

int[] arrayB = honest(arrayA);
for(int k = 0; k < arrayB.Length; k++) Console.Write($"{arrayB[k]} ");
