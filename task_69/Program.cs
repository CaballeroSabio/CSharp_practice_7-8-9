/* Задача 69:
 * Напишите программу, которая на вход принимает два числа A и B,
 * и возводит число А в целую степень B с помощью рекурсии.
 * A = 3; B = 5 -> 243 (3⁵)
 * A = 2; B = 3 -> 8
 */

Console.Clear();

Console.Write("Задайте первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int GetPower(int num1, int num2)
{
    if (num2 == 0) return 1;
    return GetPower (num1, num2 - 1) * num1;
}

if (number2 >= 0)
{
    int result = GetPower(number1, number2);
    Console.WriteLine(result);
}
else Console.WriteLine("Степень должна быть натуральной");



