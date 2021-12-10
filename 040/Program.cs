// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] makeArray()
{
    double[] array = new double[10];
    for(int i = 0; i < array.Length; i++) array[i] = new Random().NextDouble();
    return array;
}

double FindMaxValue(double[] array)
{
    double maxValue = 0.0;
    for(int i = 0; i < array.Length; i++) if(array[i] > maxValue) maxValue = array[i];
    return maxValue;
}

double FindMinValue(double[] array)
{
    double minValue = 1.0;
    for(int k = 0; k < array.Length; k++) if(array[k] < minValue) minValue = array[k];
    return minValue;
}

double SubMaxValueAndMinValue(double argMax, double argMin)
{
    return argMax - argMin;
}

double[] arrayA = makeArray();
Console.WriteLine(SubMaxValueAndMinValue(FindMaxValue(arrayA), FindMinValue(arrayA)));
