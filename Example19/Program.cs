// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Написал два вариант решения задачи, второй кажется более изящный

Console.Clear();
Console.Write("Введите число: ");
int number = Int32.Parse(Console.ReadLine());
if (number < 10000 || number > 99999){
    Console.WriteLine("Введено не пятизначное число");
    return;

// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
// }

}else if(number / 10000 == number % 10 && (number/1000)%10 == (number%100)/10){
    Console.WriteLine("Число палиндром");
}
else{
    Console.Write("Число не палиндром");

}

Console.Clear(); 
Console.Write("Введите число: "); 
string number = Console.ReadLine();
if (number.Length == 5)
{
    if(number[0] == number[4] && number[1] == number[3])
    {
    Console.WriteLine($"Число {number} - палиндром"); 
    }
    else
    {
    Console.Write($"Число {number} - не палиндром");
    }
}

else
{ 
    Console.WriteLine("Введено не пятизначное число"); 
}

