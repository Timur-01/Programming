// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
int[] elArray = GetArray(4, 1, 100);
Console.WriteLine(String.Join(" ", elArray));
int max = 0;
int min = 0;
int Diff = 0;

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

// int max = 0;
// int min = 0;
// int Diff = 0;

foreach (int el in elArray)
{
//  for (int i = 0; i < elArray.Length; i++){
//     int el = elArray[i];
    if(el > max)
        max = el;
   else
    {
    min = el;
    }
    Diff = max - min;
    
} 

Console.WriteLine($"Максимальное число = {max}, минимальное число = {min} -> разница {Diff}");