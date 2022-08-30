/*Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
*/

int[,] GetMatrix(int m, int n)
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
} // Создание рандомого массива, заполненного случайными числами

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
} // Печать двумерного массива

int[] FindMinCross(int[,] matrixResult)//Получаем одномерный массив с позицией мин значения
{
    int m = 0;
    int n = 0;
    int min = matrixResult[0, 0];
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            if (matrixResult[i, j] < min)
            {
                min = matrixResult[i, j];
                m = i;
                n = j;
            }
        }
    }
    return new int[] { m, n };
}


int[,] RemoveCross(int[,] matrixResult, int[] findMinCross)
{
    int[,] matrix = new int[matrixResult.GetLength(0) - 1, matrixResult.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (m == findMinCross[0]) m++;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (n == findMinCross[1]) n++;
            matrix[i, j] = matrixResult[m, n];
            n++;
        }
        n = 0;
        m++;
    }
    return matrix;
}


int[,] matrixResult = GetMatrix(3, 4);
PrintMatrix(matrixResult);



int[] FindMinCross = FindMinCross(matrixResult);
Console.WriteLine(FindMinCross[0] + " " + FindMinCross[1]);