/* Задача 50.
 * Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 * и возвращает значение этого элемента или же указание, что такого элемента нет.
 * Например, задан массив:
 * 1 4 7 2
 * 5 9 2 3
 * 8 4 2 4
 * 1, 7 -> такого числа в массиве нет
 */


Console.Clear();
Console.Write("Введите число номер строки от 0 до 5: ");
int numOfRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число номер столбца от 0 до 5: ");
int numOfCol = Convert.ToInt32(Console.ReadLine());

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

string FindElValue(int[,] matrixResult, int numOfRow, int numOfCol)
{   
    if (numOfRow <= 5 & numOfCol <= 5)
    {
        int i = numOfRow;
        int j = numOfCol;
        string res = Convert.ToString(matrixResult[i, j]);
        return res;
    }
    else
    {
        return "Отсутствует";
    }
}
   
int[,] matrixResult = GetMatrix(5, 5);
PrintMatrix(matrixResult);
string elemValue = FindElValue(matrixResult, numOfRow, numOfCol);
Console.WriteLine("Значение данного элемента -> " + elemValue);
