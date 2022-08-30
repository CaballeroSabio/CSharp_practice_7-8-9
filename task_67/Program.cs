/*
Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

Console.WriteLine("Задайте число: ");
int numM = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int num)
{
    if (num == 0) return;
    NaturalNumber(num - 1);
    Console.Write($"{num} ");
}

Console.Write("Задайте число:  ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;

int SumNumbers(int num)
{
   if (num != 0)
   {
      sum += num % 10 + SumNumbers(num / 10);
   }

   return sum;
}

Console.Write(SumNumbers(number));

2

int GetSumDigit(int num)
{

    int sum = num % 10;
    if (num >= 1)
        sum += GetSumDigit(num / 10);
        
    return sum;
}

3

int SumNumbers(int num)
{
   if (num != 0) sum += num % 10 + SumNumbers(num / 10);
   return sum;
}
