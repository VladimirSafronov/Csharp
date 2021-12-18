// 65. Спирально заполнить двумерный массив:
// ```
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7 
// ```

int row = 8;
int[,] spiral = new int[row, row];

int ExternalFillArray(int row) //метод заполняющий внешнее кольцо по границам
{
    int number = 1;
    for (int j = 0; j < row; j++) spiral[0, j] = number++;

    for (int i = 1; i < row; i++) spiral[i, row - 1] = number++;

    for (int j = row - 2; j >= 0; j--) spiral[row - 1, j] = number++;
    return number;
}

void InternalFillArray(int row, int number)
{
    int i = row - 2;
    int j = 0;
    row -= 2;

    while (row > 0)
    {
        while (spiral[i, j] == 0) spiral[i--, j] = number++;
        i++;
        j++;

        while (spiral[i, j] == 0) spiral[i, j++] = number++;
        j--;
        i++;
        row -= 1;

        while (spiral[i, j] == 0) spiral[i++, j] = number++;
        i--;
        j--;

        while (spiral[i,j] == 0) spiral[i,j--] = number++;
        j++;
        i--;
        row -= 1;
    }
}

void PrintArray()
{
    for (int i = 0; i < spiral.GetLength(0); i++)
    {
        for (int j = 0; j < spiral.GetLength(1); j++) 
        {
            if (spiral[i, j] > 9) Console.Write($"{spiral[i, j]} ");
            else Console.Write($" {spiral[i, j]} ");
        }
        Console.WriteLine();
    }
}

int number = ExternalFillArray(row);
InternalFillArray(row, number);
PrintArray();