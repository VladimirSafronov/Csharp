// 35. Определить, присутствует ли в заданном массиве, некоторое число 

int[] MadeArray()
{
    int[] array = new int [10];
    for(int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 10);
    return array;
}

bool FindNumber(int arg, int[] array)
{
    bool ans = false;
    int k = 0;
    while(k < array.Length) 
    {
        if(array[k] == arg) 
        {
            ans = true;
            break;
        }
        k++;
    }
    return ans;
}

int[] NewArray = MadeArray();
Console.WriteLine(String.Join(',', NewArray));
Console.WriteLine(FindNumber(5, NewArray));
