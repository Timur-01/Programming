// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if(number1 * number1 == number2 && number2 * number2 == number1)
{
    Console.Write("Является");    
}else{
    Console.Write("Не является"); 
}


Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
if (a * a == b)
{
    Console.WriteLine("b квадрат a");

}else if (b * b == a){
    Console.WriteLine("a квадрат b");
}else{
    Console.WriteLine("не является");
}