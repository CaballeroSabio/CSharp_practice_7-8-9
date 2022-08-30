/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/


int GetPower(int num, int num2)
{
    if (num2 == 0) return 1;
    return GetPower(num, num2 - 1) * num;
}
if (number2 >= 0)
{
    int result = GetPower(number, number2);
    Console.WriteLine(result);
}
else Console.WriteLine("Степень должна быть натуральна");
Console.Write("Введите первое число : ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int number2 = Convert.ToInt32(Console.ReadLine());




