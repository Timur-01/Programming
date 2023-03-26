// **Задача 69:**Напишите программу,
//  которая на вход принимает два числа A и B,
//   и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5-> 243(3⁵)

// A = 2; B = 3-> 8

using System;
using static System.Console;


Clear();
Write("Введите число: ");
int n = int.Parse(ReadLine());
Write("Введите степень: ");
int m = int.Parse(ReadLine());

// WriteLine(DegreeNumber(n, m));
// WriteLine($"A={n}; B={m}->{DegreeNumber(n)}");

// string DegreeNumber(int n, int m)
// {
//     if (m == start)
//     {
//         Console.WriteLine(end);
//         return start.ToString();
//     }

//     string s = PrintNumbers(start, end - 1) + ' ' + end.ToString();
//     Console.WriteLine(s);
//     return (s);
// }
WriteLine($"{DegreeNumber(n, m)}");

int DegreeNumber(int n, int m)
{
    if (m == 0)
        return 1;
    return (n * DegreeNumber(n, m - 1));
}

// WriteLine($"{Pow(n, m)}");
// // int res = n;
// // for (int i = 0; i < n; i++)
// // {
// //     n *= res;
// // }
// int Pow(int number, int degree)
// {
//     if (degree == 0) 
//         return 1;
//     return (number * Pow(number, degree - 1));
// }