// программа, рисующая фигуры в терминале
void DrawRectangle(int posX, int posY, int width, int height)
{
    int row = 0;
    while(row < height)
    {
        Console.SetCursorPosition(posX, posY + row);
        int count = 0;
        while(count < width)
        {
            Console.Write("+");
            count++;
        }
        row++;
    }

}

DrawRectangle(5, 2, 22, 3);