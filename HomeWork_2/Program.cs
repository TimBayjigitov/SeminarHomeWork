﻿//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите три числа: ");
int a,b,c;
int max = a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
// Первый вариант решения задачи:Console.WriteLine($"Максимальное число: {Math.Max(a, Math.Max(b, c))}");
// Второй вариант решения задачи не используя команду Math.Max:
if(a < b)
{
    max = b;
}
else
    if(b < c)
    {
        max = c;
    }
Console.WriteLine($"Максимальное число: {max}");