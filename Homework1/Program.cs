
/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/


Console.Clear();
Console.Write("Введите первое число");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число");
int b = int.Parse(Console.ReadLine());

Console.WriteLine( a);
Console.WriteLine( b);

int max = a;
int min = b;

if (a > max)max = a;
if (b > max)max = b;

Console.Write("max = ");
Console.WriteLine(max);

if (a < max)min = a;
if (b < max)min = b;

Console.Write("min = ");
Console.WriteLine(min);

