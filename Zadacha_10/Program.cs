﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число:");
int num1 = Convert.ToInt32(Console.ReadLine());


if (num1 >= 100 && num1 <= 999)
{
    int a1 = num1 / 10;
    int a2 = a1 % 10;
    Console.WriteLine("Вторая цифра введенного числа: " + a2);
}

if (num1 < 100 || num1 > 999)
{
    Console.WriteLine("Число должно быть трехзначным. Введите трехзначное число:");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int a3 = num2 / 10;
    int a4 = a3 % 10;
    Console.WriteLine("Вторая цифра введенного числа: " + a4);
}
