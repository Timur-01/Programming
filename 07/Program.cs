// Напишите программу, которая будет принимать 
//на вход два числа и выводить, 
//является ли второе число кратным первому. 
//Если второе число не кратно числу первому, 
//то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4
//16, 4  -> кратно

Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if(number1 % number2 == 0){
    Console.Write("Кратно");    
}
else{
    Console.Write($"Не кратно, остаток - {number1 % number2}"); 
}