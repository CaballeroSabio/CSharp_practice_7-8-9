/*Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.
*/

int[,] GetMatrix(int m, int n)
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
} // Создание рандомого массива, заполненного случайными числами


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
} // Печать двумерного массива

int[,] ReplacingRowsColumns(int[,] matrixResult) // Заменяет строки на столбцы двумерного массива
{
    int[,] matrixNew = new int[matrixResult.GetLength(0), matrixResult.GetLength(1)];
    for (int i = 0; i < matrixNew.GetLength(0); i++)
    {
        for (int j = 0; j < matrixNew.GetLength(1); j++)
        {
            matrixNew[i, j]  = matrixResult[i, j];
        }
    }
    return matrixNew;
}

Console.Clear();
int[,] matrixResult = GetMatrix(3, 3);
PrintMatrix(matrixResult);
Console.WriteLine();

if (matrixResult.GetLength(0) != matrixResult.GetLength(1)) Console.WriteLine("Невозможно выполнить");
else
{
    int[,] newMatrix = ReplacingRowsColumns(matrixResult);
    PrintMatrix(newMatrix);
}