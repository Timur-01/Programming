// Напишите программу, 
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09

Console.Clear();
Console.Write("Введите координаты точки ax = ");
int ax = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки ay = ");
int ay = int.Parse(Console.ReadLine());

Console.Write("Введите координаты точки bx = ");
int bx = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки by = ");
int by = int.Parse(Console.ReadLine());

double s = (Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2)));

Console.WriteLine($"Расстояние = {s:f3}");