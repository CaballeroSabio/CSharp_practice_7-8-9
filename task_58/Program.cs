/* Задача 58:
 * Задайте две матрицы.
 * Напишите программу, которая будет находить произведение двух матриц.
 * Например, даны 2 матрицы:
 * 2 4 | 3 4
 * 3 2 | 3 3
 * Результирующая матрица будет:
 * 18 20
 * 15 18
 */

Console.Clear();

void MultiplyMatrix(int[,] martrixOne, int[,] martrixTwo, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int l = 0; l < martrixOne.GetLength(1); l++)
      {
        sum += martrixOne[i,l] * martrixTwo[l,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,10);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

int[,] martrixOne = new int[3, 3];
CreateArray(martrixOne);
Console.WriteLine($"\nПервая матрица:");
WriteArray(martrixOne);
int[,] martrixTwo = new int[3, 3];
CreateArray(martrixTwo);
Console.WriteLine($"\nВторая матрица:");
WriteArray(martrixTwo);
int[,] resultMatrix = new int[3,3];
MultiplyMatrix(martrixOne, martrixTwo, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);
Console.WriteLine();

