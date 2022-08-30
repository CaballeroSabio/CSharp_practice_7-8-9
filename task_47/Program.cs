/* Задача 47:
 * Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
 * m = 3, n = 4.
 * 0,5 7 -2 -0,2
 * 1 -3,3 8 -9,9
 * 8 7,8 -7,1 9
 */

Console.Clear();

float[,] CreateMatrixRndDouble (int m, int n) // создаёт двумерный массив псевдослучайных вещественных чисел
{
    float[,] matrix = new float[m, n];
    Random rnd = new Random();    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            float res = Math.Round(rnd.NextSingle()*10, 1);
            //double resNeg = Math.Round((rnd.NextDouble()-1)*10, 1);
            matrix[i,j] = res;
            //matrix[i,j] = resNeg;
        }                
    }    
    return matrix; 
}

void PrintMatrix(float[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j], 3}|");
            else Console.Write($"{array[i,j], 3}]");
        }
        Console.WriteLine();
    }
}


float[,] matrixResult = CreateMatrixRndDouble(3, 4);
PrintMatrix(matrixResult);