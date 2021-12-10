//41. Выяснить являются ли три числа сторонами треугольника 

string InputNumbers()
{
    Console.WriteLine("Введите числа через пробел:");
    return Console.ReadLine();
}

int findLength(string num)
{
    int lengt = 0;
    for(int i = 0; i < num.Length; i++) if(num[i] == ' ') lengt +=1;
    return lengt + 1;
}

int[] arrayFromString(int numb, string numbers)
{
    int j = 0;
    int[] array = new int[numb];
    int i = 0;
    while(i < array.Length)
    {
        if(numbers[j] != ' ') 
        {
            array[i] = Int32.Parse("" + numbers[j]);  //схитрил
            i++;
            j++;
        }
        else j++;
    }
    return array;
}

bool IsThisTriangle(int[] arr)
{
    if(arr[0] + arr[1] > arr[2] && arr[1] + arr[2] > arr[0] && arr[0] + arr[2] > arr[1]) return true;
    else return false;
}

string numbers = InputNumbers();
int lengthArray = findLength(numbers);
int[] arrayA = arrayFromString(lengthArray, numbers);
Console.WriteLine(IsThisTriangle(arrayA));
