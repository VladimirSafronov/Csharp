// 23. Показать таблицу квадратов чисел от 1 до N 

double[] FuncPow(int arg)
{
    double [] array = new double [arg];
    for(int i = 1; i <= arg; i++) array[i-1] = Math.Pow(i, 2);
    return array;
}
int n = 10;
double[] Array = FuncPow(n);

for(int k = 1; k <= Array.Length; k++) Console.WriteLine($"{k}^2 = {Array[k-1]}");
