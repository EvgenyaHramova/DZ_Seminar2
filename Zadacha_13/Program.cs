// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

Console.WriteLine("Введите число:");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 < 100 && num1 > -100)
{
    Console.WriteLine("Третьей цифры в числе нет.");
}

else
{
    while (num1 > 999 || num1 < -999)
    {
        num1 = num1 / 10;
    }

int a1 = num1 % 10;

Console.WriteLine("Третья цифра введенного числа: " + Math.Abs(a1));
}
