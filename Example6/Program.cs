﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет


Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
if(number1 % 2 == 0){
    Console.Write("Да");    
}
else{
    Console.Write("Нет"); 
}