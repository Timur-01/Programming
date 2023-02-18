// Задача 36: Задайте одномерный массив,
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] elArray = GetArray(4, 1, 999);
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



//     for (int i = 0; i < elArray.Length; i++)
// {
//     int el = elArray[i];
//     if (el % 2 != 1)
//        oddSum += el;
// }
   
// Console.WriteLine($"Сумма нечётных чисел {oddSum}");

  
