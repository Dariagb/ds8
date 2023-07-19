//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2


using System;
using static System.Console;
Clear();


WriteLine("Введите размер массива X x Y x Z");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
WriteLine();

int[,,] threearray = new int[x, y, z];
GetArray (threearray);
WriteArray(threearray);

int InputNumbers(string input)
{
Write(input);
  int output = Convert.ToInt32(ReadLine());
  return output;
}

void WriteArray (int[,,] thereearray)
{
  for (int i = 0; i < thereearray.GetLength(0); i++)
  {
    for (int j = 0; j < thereearray.GetLength(1); j++)
    {
  
      for (int k = 0; k < thereearray.GetLength(2); k++)
      {
        Write( $"{thereearray[i, j, k]} ({i}, {j}, {k})   ");
      }
    WriteLine();}
  }
  WriteLine();
}

void GetArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}


