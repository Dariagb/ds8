// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
using System;
using static System.Console;

int[,] namber = new int[4, 4];
GetArray(namber);
PrintArray(namber);
WriteLine();
MinSumNumber(namber);

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void MinSumNumber(int[,] array)
{
    int minLine = 0;
    int minLineSum = 0;
    int sumLine = 0;
    for (int i = 0; i < namber.GetLength(1); i++)
    {
        minLine += namber[0, i];
    }
    for (int i = 1; i < namber.GetLength(0); i++)
    {
        for (int j = 0; j < namber.GetLength(1); j++) sumLine += namber[i, j];
        if (sumLine < minLine)
        {
            minLine = sumLine;
            minLineSum = i;
        }
      
    }
    Write($"{minLineSum + 1} строка с наименьшей суммой");
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j]+ " " );
        }
        WriteLine();
    }
}

