// Напишите программу, которая 
// 1. на вход принимает два числа и 
// 2. проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b * b == a) 
{
    Console.Write($"число {b} является квадратом {a} ");
}
else
{
    Console.Write($"число {b} не является квадратом {a} ");
}
