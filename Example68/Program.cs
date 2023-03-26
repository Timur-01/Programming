// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;
using static System.Console;


Clear();
Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());

WriteLine($"A({m},{n}) = {Ak(m, n)}");

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, A(m, n - 1));
}