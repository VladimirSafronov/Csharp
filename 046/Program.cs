// 46. Написать программу масштабирования фигуры

string Input()
{
    Console.WriteLine("Введите координаты точек через пробел:");
    return Console.ReadLine();
}

string[] fromStringToArray(string num)  //создаем строчный массив
{
    return num.Split(' ');
}

int[] fromStrToInt(string[] numbers)  //переводим строчный массив в числовой, в методе присутствует ловушка для букв
{
    int[] point = new int[numbers.Length];
    for(int i = 0; i < numbers.Length; i++)
    {
        try
        {
            point[i] = Convert.ToInt32(numbers[i]);
        }
        catch(Exception) 
        {
            Console.WriteLine("Ошибка при вводе");
        }
    }
    return point;
}

int[] Scale(int[] points, int n)
{
    // int firstSide = points[3] - points[1];
    // int secondSide = points[4] - points[2];
    int ratioSides = (points[4] - points[2]) / (points[3] - points[1]); //находим соотношение длины сторон
    int[] newPoints = new int[points.Length];
    newPoints[0] = points[0];
    newPoints[1] = points[1];
    newPoints[2] = points[2];
    newPoints[3] = points[3] * n;
    newPoints[4] = points[4] * n * ratioSides;
    newPoints[5] = points[5] * n;
    newPoints[6] = points[6] * n * ratioSides;
    newPoints[7] = points[7];
    return newPoints;   //получилось так себе. Работает, если задаем точки против часовой стрелки, начиная с нижнего левого края.
}


Console.WriteLine();
int[] points = fromStrToInt(fromStringToArray(Input()));  //числовой массив с координатами точек
int[] newPoints = Scale(points, 2);
Console.WriteLine(String.Join(',', newPoints));
