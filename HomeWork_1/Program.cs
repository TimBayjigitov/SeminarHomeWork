// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее:
int n1; 
int n2;
Console.WriteLine("Введите числа: ");
n1 = Convert.ToInt32(Console.ReadLine());
n2 = Convert.ToInt32(Console.ReadLine());
if(n1 > n2)
{
    Console.WriteLine($"{n1} max, {n2} min");
}
else
    if(n1 < n2)
    {
        Console.WriteLine($"{n2} max, {n1} min");
    }
    else
        if(n1 == n2)
        {
            Console.WriteLine($"{n1} = {n2}");
        }