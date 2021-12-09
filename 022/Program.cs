// 22. Найти расстояние между точками в пространстве 2D/3D

//формула поиска расстояния между токами A и B = корень(xB - xA)^2 + (yB - yA)^2 + (zB - zA)^2;

double SearchDistancePoints2D(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); 
}

Console.WriteLine(SearchDistancePoints2D(2, 3, -5, -7));


double SearchDistancePoints3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)); 
}

Console.WriteLine(SearchDistancePoints3D(2, 3, 2, -5, -7, -6));
