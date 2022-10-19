// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
for (;num<100 || num>999; num=Convert.ToInt32(Console.ReadLine())) Console.WriteLine("Число должно быть трехзначным");
//Console.Write(num);

//int a2 = num / 10;
//Console.WriteLine("Вторая цифра введенного числа:" + {a2});
