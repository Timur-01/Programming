// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine();
string otvet = Convert.ToString(number[number.Length - 2]);
Console.WriteLine($"Вторая цифра: {otvet}");