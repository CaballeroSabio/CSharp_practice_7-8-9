/* Задача 68:
 * Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
 * m = 3, n = 2 -> A(m,n) = 29
 */

Console.Clear();

Console.Write("Введите неотрицательное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите неотрицательное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int AckermannFunction (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AckermannFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    return AckermannFunction(m, n);
}

Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {AckermannFunction(m, n)}");
