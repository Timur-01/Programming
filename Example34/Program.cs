// Задача 34: Задайте массив заполненный
// случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.Clear();
int[] elArray = GetArray(4, 99, 999);
// int[] res = EvenArray(elArray);
// Console.WriteLine(String.Join(" ", elArray));
// Console.WriteLine($"Четных чисел - {count}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
int res = 0;
    for (int i = 0; i < elArray.Length; i++)
{
    if (elArray[i] % 2 == 0)
    {
        res++;
    }
}
Console.WriteLine($"{String.Join(" ", elArray)} -> {res}");


// void EvenArray(int count, int elArray){
//     for (int i = 0; i < elArray; i++)
// {
//     if (elArray[i] % 2 == 0)
//     {
//         res++;
//     }
//     }
//     return;
// }

// int count = 0;

// for (int x = 0; x < elArray.Length; x++)
// {
// if (elArray[x] % 2 == 0)
// count++;
// }

// Console.WriteLine($"Четных чисел - {count}");