// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
int numberA = ReadInt("Введите число: ");
int numberB = ReadInt("Введите число: ");
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
ToDegree(numberA, numberB);


// Функция возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    // Console.WriteLine(a + " в степени " + b + " = " + result);
    Console.WriteLine(result);
}

// Функция ввода
// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }