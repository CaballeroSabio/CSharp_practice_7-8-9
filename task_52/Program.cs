/* Задача 52.
 * Задайте двумерный массив из целых чисел.
 * Найдите среднее арифметическое элементов в каждом столбце.
 * Например, задан массив:
 * 1 4 7 2
 * 5 9 2 3
 * 8 4 2 4
 * Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 */

Console.Clear();
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1,10);            
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
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

void ArithmeticMean(int[,] matrixResult)
{    
    for (int j = 0; j < matrixResult.GetLength(1); j++)
    {
        double sum = 0;
        double res = 0;
        for (int i = 0; i < matrixResult.GetLength(0); i++)
        {
            sum += matrixResult[i, j];
            res = sum / matrixResult.GetLength(0);
        }
        Console.WriteLine($"Среднее арифметическое {j+1} столбца: {res}");
    }    
}

int[,] matrixResult = GetMatrix(5, 5);
Console.WriteLine("Генерируем массив");
PrintMatrix(matrixResult);
Console.WriteLine("Подсчитываем среднее арифметическое");
ArithmeticMean(matrixResult);
Console.WriteLine();