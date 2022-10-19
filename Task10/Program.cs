// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
string? number = Console.ReadLine();
int num = 0;
while(!int.TryParse(number, out num) || num < 100 || num >= 1000)
{
    Console.WriteLine("Введеное выражение не является трехзначным числом");
    Console.Write("Введите трехзначное число: ");
    number = Console.ReadLine();
}
num = (num - num/100*100) / 10;
Console.Write($"Вторая цифра введенного числа: {num}");