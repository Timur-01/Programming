// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine();
string otvet = Convert.ToString(number[number.Length - 2]);
Console.WriteLine($"2 цифра: {otvet}");

// Console.Clear();
// Console.WriteLine("Первый метод");
// Console.Write("Введите трехзначное число: ");
// int num = int.Parse(Console.ReadLine());
// if (num < 100 || num > 999){
//     Console.WriteLine("Введено не првильное число");
//     return;
// }
// int num2 = num / 10;
// int otvet = num2 % 10;
// Console.WriteLine($"3 цифра: {otvet}");
// Console.WriteLine("----------------");