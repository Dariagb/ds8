/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/


using System;
using static System.Console;

Clear();

Write("Введите количество строк 1 массива: ");
int linefirst = Convert.ToInt32(ReadLine());

Write("Введите количество столбцов 1 массива: ");
int colonfirst =  Convert.ToInt32(ReadLine());

Write("Введите количество строк 2 массива: ");
int linesecond =  Convert.ToInt32(ReadLine());

Write("Введите количество столбцов 2 массива: ");
int colonsecond =  Convert.ToInt32(ReadLine());

if (colonfirst != linesecond)
{
    WriteLine("Матирицы умножать нельзя!");
    return;
}

int[,] A = GetArray(linefirst, colonfirst, 0, 10);
int[,] B = GetArray(linesecond, colonsecond, 0, 10);
PrintArray(A); 
WriteLine();
PrintArray(B);
WriteLine("Произведение двух матриц: ");
PrintArray(CompositionMatrix(A,B));


int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}


int[,] CompositionMatrix(int[,] firstarray, int[,] secondarray)

{
    int[,] thirdarray = new int[firstarray.GetLength(0), secondarray.GetLength(1)];
    
    for (int i = 0; i < firstarray.GetLength(0); i++)
    {
        for (int j = 0; j < secondarray.GetLength(1); j++)
        {
            for (int k = 0; k < firstarray.GetLength(1); k++)
            {
                thirdarray[i, j] += firstarray[i, k] * secondarray[k, j];
                
            }
            
        } 
    }
   return thirdarray;
  

}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write(inArray[i, j] + " ");
        }
        WriteLine();
    }
}
