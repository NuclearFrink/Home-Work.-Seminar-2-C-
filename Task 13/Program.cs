/* // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите трехзначное число: ");
double number = double.Parse(Console.ReadLine());

if (number > 3)
{
    number = double.Parse(Math.Pow(10, number - 3));
    Console.WriteLine("Третья цифра: ");
}
else
{
    if (number <= 2) ;
    Console.WriteLine("Третьей цифры нет.!");
}