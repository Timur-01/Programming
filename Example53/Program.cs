
//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
Write("Введите строку 1: ");
int a = int.Parse(ReadLine());
Write("Введите строку 2: ");
int b = int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
ChangeRows(array, a, b);
PrintArray(array);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

void ChangeRows(int[,] inArray, int a, int b)
{
    
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        int k = inArray[a - 1, i];
        inArray[a - 1, i] = inArray[b - 1, i];
        inArray[b - 1, i] = k;
    }
}