// 20. Ввести номер четверти, показать диапазоны для возможных координат

string InputQuarter()
{
    Console.WriteLine("Введите номер четверти: ");
    string a = Console.ReadLine();
    int arg = Convert.ToInt16(a);
    if(arg == 1) return ($"x>0, y>0");
    if(arg == 2) return ($"x<0, y>0");
    if(arg == 3) return ($"x<0, y<0");
    if(arg == 4) return ($"x>0, y<0");
    else return ($"Впишите номер от 1 до 4!");
}

string ans = InputQuarter();
Console.WriteLine(ans);
