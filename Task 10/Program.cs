// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число ");
int digit = int.Parse(Console.ReadLine());

if (digit > 99 & digit < 1000)
{
   int digit_1 = digit % 100;
   int digit_2 = digit_1 / 10;
   Console.WriteLine($"Вторая цифра: {digit_2}");
}

else 
{
    Console.WriteLine("Число не является трехзначным");
}