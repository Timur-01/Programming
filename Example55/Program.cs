//Задайте двумерный массив. Напишите программу, 
//которая заменяет строки на столбцы. В случае, 
//если это невозможно, программа должна вывести сообщение для пользователя.
using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());



int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
PrintArray(ChangeArray1(array));
WriteLine();


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

int[,] ChangeArray1(int[,] array)
{
    int[,] result = new int [array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[j, i] = array[i, j];
        }
    }
    return result;
}

void ChangeArray2(int[,] array)
{
    if (rows != columns)
    {
        WriteLine("В данной матрице нельзя заменить элементы!");
        return;
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int k = array[j, i];
            array[j, i] = array[i, j];
            array[i, j] = k;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}