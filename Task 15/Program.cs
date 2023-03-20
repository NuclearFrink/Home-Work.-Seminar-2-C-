/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */


Console.Write("Введите цифру дня недели: ");
int number = int.Parse(Console.ReadLine());

if (number < 1 | number > 7)
{
    Console.WriteLine("Неделя длится от 1 до 7");
}
if (number == 6 | number == 7)
{
    Console.WriteLine("Выходной день! Можно пойти в кино!");
}
if (number > 0 & number < 6)
{
    Console.WriteLine("Рабочая неделя в самом разгаре!");
}