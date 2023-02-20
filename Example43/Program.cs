// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.Write("Введите точки прямых: ");

string[] st = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
double b1 = int.Parse(st[0]);
double k1 = int.Parse(st[1]);
double b2 = int.Parse(st[2]);
double k2 = int.Parse(st[3]);

double x = -(b1 - b2) / (k1 - k2);
double y = k2 * x + b2;

x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");