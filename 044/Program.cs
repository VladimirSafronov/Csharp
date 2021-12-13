// 44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

// k1 * x + b1 = k2 * x + b2
// k1 * x - k2 * x = b2 - b1
// x = (b2 - b1) / (k1 - k2)
// y = k1 * (b2 - b1) / (k1 - k2) + b1

int FindY(int[] array) 
{
    if (array[1] == array[3]) return 0;
    return array[1] * (array[2] - array[0]) / (array[1] - array[3]) + array[0];
}

int FindX(int[] array) 
{
    return (array[2] - array[0]) / (array[1] - array[3]);
}

string[] StringToArray(string text) //переводим из строки в строчный массив
{
    string[] array = new string[ArrayLength(text)]; 
    for (int i = 0, j = 0; i < text.Length; i++)
    {
        array[j] = array[j] + text[i];
        if (text[i] == ' ') j++;
    }
    return array;
}

int ArrayLength(string text) //метод подсчитывающий пробелы, чтобы знать длинну массива
{
    int length = 1;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == ' ') length += 1;
    }
    return length;
}

int[] FromStringArrayToIntArray(string[] array) // переводим из строчного массива в числовой
{
    int[] arrayNumbers = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        try
        {
            arrayNumbers[i] = Convert.ToInt32(array[i]);
        }
        catch (Exception)
        {
            Console.WriteLine("Введите числа через пробел");
        }
    }
    return arrayNumbers;
}

int[] Input()
{
    Console.WriteLine("Введите b1,  k1,  b2,  k2 через пробел и нажмитие ввод");
    string condition = Console.ReadLine(); 
    string[] arrayString = StringToArray(condition);
    int[] arrayCondition = FromStringArrayToIntArray(arrayString);
    return arrayCondition;
} 

void Answer(int[] array)
{
    if (array[1] == array[3])
    {
        Console.WriteLine("Прямые параллельны");
        if (array[0] != array[2]) Console.WriteLine("Прямые не имеют пересечений");
    }
    else Console.WriteLine($"x = {FindX(array)}, y = {FindY(array)}");
}

int[] condition = Input();
Answer(condition);
