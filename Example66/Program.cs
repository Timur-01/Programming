// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;


Clear();
Write("Введите start: ");
int n = int.Parse(ReadLine());
Write("Введите end: ");
int m = int.Parse(ReadLine());

// WriteLine($"{m}->{SumNumbers(m)}");
// int sum = 0;
// while(m > 0){
//     sum += m % 10; // <=> sum = sum + m % 10
//     m /= 10; // <=> m = m / 10
// }
// WriteLine($"{sum}");


// int SumNumbers(int number)
// {
//     if (number == 0)
//         return 0;
//     return (number % 10 + SumNumbers(number / 10));
// }

WriteLine($"{SumNumber(n, m)}");

int SumNumber(int n, int m)
{
    if (n == m)
        return n;
    return (n + SumNumber(n + 1, m));
}