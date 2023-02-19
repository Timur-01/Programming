// Задача 36: Задайте одномерный массив,
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.Clear();
// // Console.Write("Введите элементы массива через пробел: ");
// // string elements = Console.ReadLine();
// int[] elArray = GetArray(4, 1, 999);
// int[] elArray = GetArrayFromString(elements);
// Console.WriteLine(String.Join(" ", GetArray(elArray)));

// Console.WriteLine(String.Join(" ", ResultArray(baseArray)));

// int[] GetArrayFromString(string stringArray)
// {
//     string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
//     int[] res = new int[nums.Length];

//     for (int i = 0; i < nums.Length; i++)
//     {
//         res[i] = int.Parse(nums[i]);
//     }
//     return res;
// }

Console.Clear();
int[] elArray = GetArray(4, 1, 1000);
Console.WriteLine(String.Join(" ", elArray));
int oddSum = 0;

    for (int i = 0; i < elArray.Length; i++)
{
    int el = elArray[i];
    if (el % 2 != 0)
       oddSum += el;
}

Console.WriteLine($"Сумма нечётных чисел {oddSum}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}


