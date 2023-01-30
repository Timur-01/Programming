//Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.
Console.Clear();
Console.WriteLine("Первый метод");
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100 || num > 999){
    Console.WriteLine("Введено не првильное число");
    return;
}
int otvet = num % 10;
Console.WriteLine($"3 цифра: {otvet}");
Console.WriteLine("----------------");
Console.WriteLine("Второй метод");
string number2 = Console.ReadLine();
string otvet2 = Convert.ToString(number2[number2.Length - 1]);
Console.WriteLine($"3 цифра: {otvet2}");