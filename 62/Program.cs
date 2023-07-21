using System;
using static System.Console;

Clear();

int length = 4;
int[,] table = new int[length, length];
SpiralArray(table, length);
PrintArray(table);


void SpiralArray(int[,] array, int m)
{
    int i = 0, j = 0;
    int value = 1;
    for (int l = 0; l < m * m; l++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < m - 1);
        for (k = 0; k < m - 1; k++) array[i++, j] = value++;
        for (k = 0; k < m - 1; k++) array[i, j--] = value++;
        for (k = 0; k < m - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        m = m < 2 ? 0 : m - 2;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

