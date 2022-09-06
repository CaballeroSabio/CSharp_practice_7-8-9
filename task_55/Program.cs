/*Задача 55:
 * Задайте двумерный массив. Напишите программу,
 * которая заменяет строки на столбцы. В случае, если это
 * невозможно, программа должна вывести сообщение для
 * пользователя.
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
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j], 3},");
            else Console.Write($"{array[i,j], 3}]");
        }
        Console.WriteLine();
    }
} 

int[,] ReplacingRowsColumns(int[,] matrixResult) // Заменяет строки на столбцы двумерного массива
{
    int[,] matrixNew = new int[matrixResult.GetLength(0), matrixResult.GetLength(1)];
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            matrixNew[i, j]  = matrixResult[j, i];
        }
    }
    return matrixNew;
}

Console.Clear();

int[,] matrixResult = GetMatrix(4, 4);
PrintMatrix(matrixResult);

Console.WriteLine();

if (matrixResult.GetLength(0) != matrixResult.GetLength(1)) Console.WriteLine("Невозможно выполнить, т.к. количество строк не равно количеству столбцов");
else
{
    int[,] newMatrix = ReplacingRowsColumns(matrixResult);
    PrintMatrix(newMatrix);
}

Console.WriteLine();