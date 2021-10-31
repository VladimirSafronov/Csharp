// Подсчитать количество натуральных чисел, не превосходящих заданного числа n, которые
// делятся на k, и на l
// делятся хотябы на k или на l
// не делятся на (k + l)

int n = 50;
int k = 3;
int l = 4;

int [] arr = new int [n];
int index = 0;
while(index < n)
{
    arr[index] = index;
    index++;
}

//===делятся на k, и на l===
// index = 1;
// while(index < n)
// {
//     if(arr[index] % k == 0)
//     {
//         if(arr[index] % l == 0)
//         Console.WriteLine(arr[index]);
//     }
//     index++;
// }
//=========================================

//===делятся хотябы на k или на l===
// index = 1;
// while(index < n)
// {
//     if(arr[index] % k == 0)
//     {
//         Console.WriteLine(arr[index]);
//     }
//     if(arr[index] % l == 0)
//     {
//         Console.WriteLine(arr[index]);
//     }
//     index++;
// }
//=========================================
//===не делятся на (k + l)===(не внимательно прочитал задание, здесь я вывел на экран именно количество чисел, которые не делятся
index = 1;
int sum = k + l;
int num = 0;
while(index < n)
{
    if(arr[index] % sum == 0)
    {
        num = num + 1;
    }
    index++;
}

int ans = n - num;
Console.WriteLine(ans);



