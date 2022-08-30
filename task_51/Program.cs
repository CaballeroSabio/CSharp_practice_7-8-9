/* Задача 51:
 * Задайте двумерный массив. 
 * Найдите сумму элементов, находящихся на главной диагонали (с индексами
 * (0,0); (1;1) и т.д.
 * Например, задан массив:
 * 1 4 7 2
 * 5 9 2 3
 * 8 4 2 4
 * Сумма элементов главной диагонали: 1+9+2 = 12
 * 20 мин
 * Новый массив будет выглядеть
 * вот так:
 * 1 4 7 2
 * 5 81 2 9
 * 8 4 2 4
 */

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

int GetSumElem(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum += matrix[i, j];
        }
    }
    return sum;
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

int GetSumOpt(int[,] arr)
{
    int sum = 0;
    int length = 0;
    if(arr.GetLength(0) >= arr.GetLength(1)) length = arr.GetLength(1);
    else length = arr.GetLength(0);
    for (int j = 0; j < length; j++) sum += arr[j,j];    
    return sum;
}

int[,] matrixResult = GetMatrix(5, 5);
PrintMatrix(matrixResult);
int res1 = GetSumElem(matrixResult);
Console.WriteLine($"Сумма элементов главной диагонали равна -> {res1}");
int res2 = GetSumOpt(matrixResult);
Console.WriteLine("Сумма элементов главной диагонали равна (оптимизированный алгоритм) -> " + res2);
