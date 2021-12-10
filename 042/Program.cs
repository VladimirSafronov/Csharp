// // 42. Определить сколько чисел больше 0 введено с клавиатуры

string EnteredNumbers()
{
    Console.WriteLine("Введите число через запятую:");
    return Console.ReadLine();
}

int ArrayLength (string text) 
{
    int ans = 0;
    for(int i = 0; i < text.Length; i++)
    {
        if(text[i] == ',') ans++; 
    }
    return ans + 1;
}

string[] translateToArray(string text, int lengthArr)   
{
    string[] array = new string[lengthArr];
    int index = 0;
    for(int i = 0; i < text.Length; i++)   
    {
        if(text[i] != ',') array[index] = array[index] + text[i];
        else index++;
    } 
    return array;
}

int[] fromStringToInt (string[] arrayText)
{
    int[] array = new int[arrayText.Length];
    for(int i = 0; i < arrayText.Length; i++) array[i] = int.Parse(arrayText[i]);
    return array;
}

int PositiveNumbers (int[] array)
{
    int ans = 0;
    for(int l = 0; l < array.Length; l++) 
    {
        if(array[l] > 0) ans +=1;
    }
    return ans;
}

string text = EnteredNumbers();
string[] textArray = translateToArray(text, ArrayLength(text));
int[] arrayNumbers = fromStringToInt(textArray);
Console.WriteLine(PositiveNumbers(arrayNumbers));

// __________________________________
// string abc = "hf,kv,udhvtu,5,8,fg,h4,-5";

// int lengthOfArray (string text)  //метод, находящий длинну текстового массива
// {
//     int ans = 0;
//     for(int i = 0; i < text.Length; i++)
//     {
//         if(text[i] == ',') ans++; 
//     }
//     return ans + 1;
// }

// Console.WriteLine(lengthOfArray(abc));

// string[] translateToArray(string text, int lengthArr)   //метод, создающий строчный массив из текста
// {
//     string[] array = new string[lengthArr];
//     int index = 0;
//     for(int i = 0; i < text.Length; i++)   //имеется встроенный функционал - phrase.Split
//     {
//         if(text[i] != ',') array[index] = array[index] + text[i];
//         else index++;
//     } 
//     return array;
// }

// string[] textArray = translateToArray(abc, lengthOfArray(abc));

// Console.WriteLine(String.Join(',', textArray));

// string[] filtrNumbers(string[] array)   //не закончил, тут пытаюсь оставить только элементы с числовыми значениями
// {
//     string[] filtrArr = new string[array.Length];
//     int count = 0;
//     for(int k = 0; k < array.Length; k++)
//     {
//        if(array[k] == '-');
//     }
// }
