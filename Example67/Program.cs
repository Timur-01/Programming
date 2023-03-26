//Напишите программу, которая будет принимать на вход 
//число и возвращать сумму его цифр.

using System;
using static System.Console;


Clear();
Write("Введите число: ");
int m = int.Parse(ReadLine());

WriteLine($"{m}->{SumNumbers(m)}");
// int sum = 0;
// while(m > 0){
//     sum += m % 10; // <=> sum = sum + m % 10
//     m /= 10; // <=> m = m / 10
// }
// WriteLine($"{sum}");


int SumNumbers(int number)
{
    if (number == 0)
        return 0;
    return (number % 10 + SumNumbers(number / 10));
}