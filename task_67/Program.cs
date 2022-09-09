/* Задача 67:
 * Напишите программу, которая будет принимать на вход число и
 * возвращать сумму его цифр.
 * 453 -> 12
 * 45 -> 9
 */

Console.Clear();

// 1 вариант решения

Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());

int sum = 0;

int Sum (int n, int sum)
{
    if (n == 0) return sum;
    sum += n % 10;
    return Sum (n / 10, sum);
}

int c = Sum (m, 0);
Console.WriteLine (c);

// 2 вариант решения рабочий

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int GetSumDigit(int num)
{
    int sum = num % 10;
    if (num >= 1) sum += GetSumDigit(num / 10);
    return sum;            
}

int result = GetSumDigit (number);
Console.WriteLine ($"Сумма цифр равна -> {result}");