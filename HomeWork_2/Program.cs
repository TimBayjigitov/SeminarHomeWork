//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a,b,c;
Console.WriteLine("Введите три числа: ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
int max = a;
// Первый вариант решения задачи:Console.WriteLine($"Максимальное число: {Math.Max(a, Math.Max(b, c))}");
// Второй вариант решения задачи не используя команду Math.Max:
if(b > max)
{
    max = b;
}
if(c > max)
{
     max = c;
}
Console.WriteLine($"Максимальное число: {max}");