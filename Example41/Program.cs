// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Clear();
// Console.Write("Введите стороны треугольника через пробел: ");

// string[] st = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
// int a = int.Parse(st[0]);
// int b = int.Parse(st[1]);
// int c = int.Parse(st[2]);

Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);
int count = 0;

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

    for (int i = 0; i < baseArray.Length; i++)
{
    if (baseArray[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"{String.Join(", ", baseArray)} -> {count}");

