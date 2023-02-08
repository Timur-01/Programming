//Напишите программу, которая выводит случайное 
//трёхзначное число и удаляет вторую цифру 
//этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

// Console.Clear();
// int num = new Random().Next(100, 1000);
// Console.WriteLine($"Num = {num}");
// int result = (num / 100) * 10 + num % 10;
// Console.WriteLine($"Результат = {result}");


Console.Clear();
int num = new Random().Next(100, 1000);
// Console.WriteLine($"{num} -> {result}");
Console.WriteLine($"{num} -> {num/100}{num%10}");