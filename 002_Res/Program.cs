// Практика с логическими операциями
int a = 13;
int b = 56;
int con = a & b; // конъюнкция, опереция И, логическое умножение. Истина тогда, когда оба истинны.
int diz = a | b; // дизъюнкция (логическое или). Ложное тогда, когда оба ложные
int razdiz = a ^ b;  // разделительная дизъюнкция (логическое исключение ИЛИ). Истина тогда, когда одно из выражений истинно.
bool stories = false; // ! отрицание

Console.WriteLine($"con = {con}");
Console.WriteLine($"res = {diz}");
Console.WriteLine($"razdiz = {razdiz}");
Console.WriteLine(!stories);


