/* Задача 60.
 * Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 * Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
 * массив размером 2 x 2 x 2
 * 66(0,0,0) 25(0,1,0)
 * 34(1,0,0) 41(1,1,0)
 * 27(0,0,1) 90(0,1,1)
 * 26(1,0,1) 55(1,1,1)
 */

Console.Clear();
/*
int[,,] GetMatrix(int m, int n, int z)
{
    int[,,] matrix = new int[m, n, z];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                matrix[i, j, k] = rnd.Next(1,100);
            }           
        }
    }
    return matrix;
}
*/
/*
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
*/
void PrintMatrix3D (int[,,] matrix3D)
{
  for (int i = 0; i < matrix3D.GetLength(0); i++)
  {
    for (int j = 0; j < matrix3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < matrix3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={matrix3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void GetMatrix3D(int[,,] matrix3D)
{
  int[] temp = new int[matrix3D.GetLength(0) * matrix3D.GetLength(1) * matrix3D.GetLength(2)];
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
  for (int x = 0; x < matrix3D.GetLength(0); x++)
  {
    for (int y = 0; y < matrix3D.GetLength(1); y++)
    {
      for (int z = 0; z < matrix3D.GetLength(2); z++)
      {
        matrix3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

//Console.Clear();
//Console.WriteLine($"Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
//Console.WriteLine($"\nВведите размер массива X x Y x Z:");
//int x = InputNumbers("Введите X: ");
//int y = InputNumbers("Введите Y: ");
//int z = InputNumbers("Введите Z: ");
//Console.WriteLine($"");

int[,,] matrix3D = new int[2, 2, 2];
GetMatrix3D(matrix3D);
PrintMatrix3D(matrix3D);