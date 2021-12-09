// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int FindQuarter(int x, int y)
{
    if(x > 0 & y > 0) return 1;
    if(x < 0 & y > 0) return 2;
    if(x < 0 & y < 0) return 3;
    else return 4;
}

Console.WriteLine(FindQuarter(3, -3));
