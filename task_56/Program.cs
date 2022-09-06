/* Задача 56
 * Задайте прямоугольный двумерный массив.
 * Напишите программу, которая будет находить строку с наименьшей суммой элементов.
 * Например, задан массив:
 * 1 4 7 2
 * 5 9 2 3
 * 8 4 2 4
 * 5 2 6 7
 * Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 */

Console.Clear();

int[,] GetMatrix(int m, int n) // Создание двумерного массива, заполненного случайными числами
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
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

void GetMinSumElem(int[,] matrix)
{
    int sumI = 0, minI = 0, minSumI = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumI += matrix[i, j];
            //if (sumI <= minSumI) sumI = minSumI;
            //minI = i;           
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sumI}");
        if (i == 0) minSumI = sumI;
        else if (sumI < minSumI)
        {
            minSumI = sumI;
            minI = i;
        }        
    }
    /*string line = string.Empty;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        line += matrix[minI, j] + " ";
    }
    Console.WriteLine($"Строка с минимальной суммой элементов -> {line}");
    */
    Console.WriteLine($"Строка с минимальной суммой элементов -> {minI+1}");
}

int[,] matrixResult = GetMatrix(3, 5);
PrintMatrix(matrixResult);
GetMinSumElem(matrixResult);
//Console.Write($"Строка с минимальной суммой элементов -> {res}");
Console.WriteLine();