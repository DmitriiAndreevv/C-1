/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/


Console.Clear();
Console.Write("Введите число");
int number = int.Parse(Console.ReadLine());

Console.Write("Введите второе число");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье число");
int number3 = int.Parse(Console.ReadLine());

int max = number;
int avg = number2;
int min = number3;

if (number > max)max = number;
if (number2 > max)max = number2;
if (number3 > max)max = number3;
{
    Console.WriteLine(max);
}
Console.WriteLine($"max{max}");

