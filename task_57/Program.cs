/* Задача 57:
 * Составить частотный словарь элементов
 * двумерного массива. Частотный словарь содержит
 * информацию о том, сколько раз встречается элемент
 * входных данных.
 */

Console.Clear();

int[,] GetMatrix(int m, int n) // Создание рандомого массива, заполненного случайными числами
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

int[] ConversionArray(int[,] array) // Переводим двумерный массив в одномерный
{
    int[] arrayNew = new int[array.Length];
    int m = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayNew[m] = array[i, j];
            m++;
        }
    }
    Array.Sort(arrayNew);
    return arrayNew;
}

void WriteDigitCountToConsole(int[] arrayNew)
{
    int number = arrayNew[0];
    int count = 0;
    for (int i = 0; i < arrayNew.Length; i++)
    {
        if (arrayNew[i] == number) count++;
        else
        {
            Console.WriteLine($"Число {number} -> {count} раз(-а)");
            number = arrayNew[i];
            count = 1;
        }
        if (i == arrayNew.Length - 1)
            Console.WriteLine($"Число {number} -> {count} раз(-а)");
    }
}

int[,] matrixResult = GetMatrix(3, 3);
PrintMatrix(matrixResult);
Console.WriteLine();
int[] arrayNew = ConversionArray(matrixResult);
WriteDigitCountToConsole(arrayNew);
Console.WriteLine();


