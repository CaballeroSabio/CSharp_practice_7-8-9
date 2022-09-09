/* Задача 65:
 * Задайте значения M и N.
 * Напишите программу,
 * которая выведет все натуральные числа в промежутке от M до N.
 * M = 1; N = 5 -> "1, 2, 3, 4, 5"
 * M = 4; N = 8 -> "4, 6, 7, 8"
 */

// 1 вариант решения

Console.Clear();

Console.Write("Задайте число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {m}, N = {n} -> ");
GetNaturalNums (m, n);

void GetNaturalNums (int m, int n)
{
    if (n == m) Console.Write($"{m} ");
    else if (m < n) WriteNaturalNumAsc (m, n);
    else WriteNaturalNumDesc (n, m);
}

void WriteNaturalNumAsc (int from, int to)
{
    if (from > to) return;
    Console.Write($"{from} ");
    WriteNaturalNumAsc (++from, to);    
}

void WriteNaturalNumDesc (int from, int to)
{
    if (from > to) return;
    Console.Write($"{to} ");
    WriteNaturalNumDesc (from, --to);    
}

// 2 вариант решения

Console.Write("Задайте начальное число диапазона: ");
int numM = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте конечное число диапазона: ");
int numN = Convert.ToInt32(Console.ReadLine());

void NaturalNumber (int num, int number)
{
    if (num == number)
    {
        Console.Write($"{num} ");
        return;
    }
    if (num > number)
    {
        Console.Write($"{num} ");
        NaturalNumber (num - 1, number);
    }
    else
    {
        NaturalNumber (number - 1, num);
        Console.Write($"{number} ");
        
    }
}

NaturalNumber(numM, numN);