/* Задача 66:
 * Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
 * M = 1; N = 15 -> 120
 * M = 4; N = 8. -> 30
 */

Console.Clear();

Console.Write("Введите начальное число диапазона сложения: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конечное число диапазона сложения: ");
int n = Convert.ToInt32(Console.ReadLine());

void GetSumDigitForScale (int num1, int num2, int sum)
{
    if (num1 >= 0 && num2 >= 0)
    {
        if (num1 > num2) 
            {
                Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
                return;            
            }
            sum += (num1++);
            GetSumDigitForScale(num1, num2, sum);
    }
    else
    {
        Console.WriteLine("Введены отрицательные числа");
        return;
    }    
}

GetSumDigitForScale (m, n, 0);

