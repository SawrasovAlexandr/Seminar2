// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
string? day = Console.ReadLine();
int weekday = 0;
while(!int.TryParse(day, out weekday) || weekday <= 1 || weekday >= 7)
{
    Console.Write("Введите число от 1 до 7: ");
    day = Console.ReadLine();
}
if (weekday >= 6) Console.WriteLine("Выходной!!");
else Console.WriteLine("Суровые будни(");
