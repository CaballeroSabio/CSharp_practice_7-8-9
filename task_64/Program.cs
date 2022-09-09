/* Задача 64:
 * Задайте значение N. Напишите программу,
 * которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
 * N = 5 -> "5, 4, 3, 2, 1"
 * N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
 */

Console.Clear();

Console.Write("Задайте конечное число диапазона, превышающее или равное 1: ");
int numM = Convert.ToInt32(Console.ReadLine());

int numN = 1;

void NaturalNumber (int num, int number)
{
    if (num == number)
    {
        Console.WriteLine($"{num} ");
        return;
    }
    if (num > number)
    {
        Console.WriteLine($"{num} ");
        NaturalNumber (num - 1, number);
    }
    else
    {        
        Console.Write("Введено неверное значение");
        Console.WriteLine();
    }
}

NaturalNumber(numM, numN);
Console.WriteLine("Press any key");
Console.ReadKey();

