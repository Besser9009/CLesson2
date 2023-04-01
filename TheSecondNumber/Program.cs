Console.Clear();
System.Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
System.Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
int num2_1 = num % 100;
int num2 = num2_1 / 10;
System.Console.WriteLine($"Вторая цифра вашего числа: {num2}");