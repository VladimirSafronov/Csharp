// 64. Показать треугольник Паскаля
// *Сделать вывод в виде равнобедренного треугольника

int row = 10;  //высота треугольника
int[,] triangle = new int[row, row];
const int cellWidth = 3;  //кол-во отступов для печати след. элемента

void FillTriangle()
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < row; i++) //первые две строки треугольника заполнены единицами
    {
        for (int j = 1; j <=i; j++) //по границам всегда единица
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j]; //заполнение "внутренности" треугольника
        }
    }
}

void PrintTriangle()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");
        }
        Console.WriteLine();
    }
}

void IsoscelesTriangle()
{
    int col = cellWidth * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <=i; j++)
        {
            Console.SetCursorPosition(col, i + 1);  //устанавливаем курсор с нужным отступом
            if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");
            col += cellWidth * 2; //увеличиваем отступ для печати следующего элемента строки
        }
        col = cellWidth * row - cellWidth * (i + 1);  //для печати следующей строки отступ понадобится меньше
        Console.WriteLine();
    }
}

FillTriangle();
//PrintTriangle();
IsoscelesTriangle();