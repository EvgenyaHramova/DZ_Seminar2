// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число:");
int num1 = Convert.ToInt32(Console.ReadLine());

// Синтаксис строки 7 нашла на форуме в интернете, мне кажется так мешьше код и удобнее
for (; num1 < 100 || num1 > 999; num1 = Convert.ToInt32(Console.ReadLine())) Console.WriteLine("Число должно быть трехзначным, введите трехзначное число:");

int a1 = num1 / 10;
int a2 = a1 % 10;
Console.WriteLine("Вторая цифра введенного числа: " + a2);

