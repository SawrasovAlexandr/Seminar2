// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100,1000);
Console.WriteLine(number);
int number1 = number/100;
int number3 = number%10;
Console.Write(number1);
Console.Write(number3);

// int number = new Random().Next(100,1000);
// Console.WriteLine(number);
//     //string strnum = $"{number}";       //альтернативные варианты
//     //string strnum = number.ToString(); //преобразования int в string
// string strnum = Convert.ToString(number);
// Console.WriteLine($"{strnum[0]}{strnum[2]}");