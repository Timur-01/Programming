//Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.Clear();
Console.Write("Введите номер дня недели: ");
int numberDayOfWeek = int.Parse(Console.ReadLine());
if (numberDayOfWeek < 1 || numberDayOfWeek > 7)
{
    Console.WriteLine("Введен неправильный номер");
    return;
}

if (numberDayOfWeek == 1)
{
    Console.WriteLine("Понедельник");
}
else if (numberDayOfWeek == 2)
{
    Console.WriteLine("Вторник");
}
else if (numberDayOfWeek == 3)
{
    Console.WriteLine("Среда");
}
else if (numberDayOfWeek == 4)
{
    Console.WriteLine("Четверг");
}
else if (numberDayOfWeek == 5)
{
    Console.WriteLine("Пятница");
}
else if (numberDayOfWeek == 6)
{
    Console.WriteLine("Суббота");
}
else if (numberDayOfWeek == 7)
{
    Console.WriteLine("Воскресенье");
}