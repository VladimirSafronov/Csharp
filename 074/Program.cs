// 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые 
// можно построить из букв этого алфавита.
int k = 1;
void ShowWords(string text, char[] letter, int length = 0)
{
    if (length == letter.Length)
    {
        Console.WriteLine($"{k++} {new String(letter)}"); return;
    }
    for (int i = 0; i < text.Length; i++)
    {
        letter[length] = text[i];
        ShowWords(text, letter, length +1);
    }
}

ShowWords("аисв", new char[4]);
