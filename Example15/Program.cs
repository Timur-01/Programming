// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите номер дня недели: ");
int numberDayOfWeek = int.Parse(Console.ReadLine());
if (numberDayOfWeek < 1 || numberDayOfWeek > 7)
{
    Console.WriteLine("Введен неправильный номер");
    return;
}

if (numberDayOfWeek == 1 || numberDayOfWeek < 6)
{
    Console.WriteLine("Будний день");
}
else if (numberDayOfWeek > 5 || numberDayOfWeek == 7)
{
    Console.WriteLine("Выходной");
}
