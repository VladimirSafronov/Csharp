// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным днём

bool FindWeekend(int arg)
{
    if (arg == 6 || arg == 7) return true;
    else return false;
}

Console.WriteLine(FindWeekend(7));
