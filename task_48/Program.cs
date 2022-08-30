/* Задача 48:
 * Задайте двумерный массив размера m на n,
 * каждый элемент в массиве находится по формуле: Amn = m+n.
 * Выведите полученный массив на экран.
 * m = 3, n = 4.
 * 0 1 2 3
 * 1 2 3 4
 * 2 3 4 5
 */

int[,] array = SetArray(3,4);

PrintMatrix(array);

int[,] SetArray(int rows, int columns)
{
    var array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j], 3},");
            else Console.Write($"{array[i,j], 3}]");
        }
    Console.WriteLine();
    }
}