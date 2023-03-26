// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;
using static System.Console;

Clear();
Write("Введите N: ");
int n = int.Parse(ReadLine());

WriteLine(PrintNumbers(n));

string PrintNumbers(int n)
{
    if (n == 1) 
    return n.ToString();
    return (n + " " + PrintNumbers(n - 1));
}

// Clear();
// Write("Введите start: ");
// int n = int.Parse(ReadLine());
// Write("Введите end: ");
// int m = int.Parse(ReadLine());

// WriteLine(PrintNumbers(n, m));
// string PrintNumbers(int start, int end)
// {
//     if (end == start)
//     {
//         WriteLine(end);
//         return start.ToString();
//     }

//     string s = PrintNumbers(start + 1, end) + ' ' + start.ToString();
//     WriteLine(s);
//     return s;
// }

