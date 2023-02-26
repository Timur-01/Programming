
// Задача 59. Из двумерного массива целых чисел удалить строку и столбец, 
//на пересечении которых расположен первый найденный наименьший элемент.

Console.Clear();

int[,,] triplearray = {{{001, 002, 003},{011, 012, 013},{021, 022, 023}},
{{101, 102, 103},{111, 112, 113},{121, 122, 123}},
{{201, 202, 203},{211, 212, 213},{221, 222, 223}}};

void pr(int[,,] array){
    int a = array.GetLength(0);
    int b = array.GetLength(1);
    int c = array.GetLength(2);

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                Console.Write($"{array[i,j,k]}({i} {j} {k})");
            }
            Console.WriteLine();
        }
         Console.WriteLine();
    }
}
pr(triplearray);
