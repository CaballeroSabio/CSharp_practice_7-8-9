/* Задача 54:
 * Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
 * Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
* В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] GetMatrix(int m, int n) // Создание рандомого массива, заполненного случайными числами
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 100);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array) // Печать двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3},");
            else Console.Write($"{array[i, j],3}]");
        }
        Console.WriteLine();
    }
}

void SortDescending(int[,] array) // Функция сортировки элементов в строке двумерного массива, по убыванию
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(1) - 1; l++)
            {
                if (array[i, l] < array[i, l + 1])
                {
                    int temp = array[i, l + 1];
                    array[i, l + 1] = array[i, l];
                    array[i, l] = temp;
                }
            }
        }
    }
}

int[,] matrix = GetMatrix(5, 5);
PrintMatrix(matrix);
SortDescending(matrix);
Console.WriteLine();
PrintMatrix(matrix);
