// 30. Показать кубы чисел, заканчивающихся на четную цифру

double[] CubeLastEvenNum(int first, int last)   
{
    double [] array = new double[(last - first +1) / 2];  //+1, чтобы влезало в массив при четном начале
    if(first % 2 != 0) first +=1;
    int count = 0;
    for(int i = first; i <= last; i+=2) 
    {
        array[count] = Math.Pow(i, 3); 
        count++;
    }
    return array;
}
double[] Array = CubeLastEvenNum(8, 21); 
for(int j = 0; j < Array.Length; j++) Console.WriteLine(Array[j]);
