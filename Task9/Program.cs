// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int number = new Random().Next(10,100);
Console.WriteLine(number);
int number1 = number/10;
int number2 = number%10;
Console.Write(number1 > number2 ? number1 : number2);
