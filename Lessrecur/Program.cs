Console.WriteLine("Задайте значение N: ");
int N = int.Parse(Console.ReadLine()!);

int summ = 0;

int SumRec(int M, int N, int summ = 0)
{
if (M > N)
{
M = N;
N = summ;
}
summ = summ + N;

return N <= M ? N : SumRec(M, N - 1) + summ;
}

Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"Сумма элементов= {SumRec(M, N, summ)} ");
Console.ForegroundColor = ConsoleColor.White;