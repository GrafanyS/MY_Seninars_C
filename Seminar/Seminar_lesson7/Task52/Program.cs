// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] massive = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };//заднный масив

int m = 3;//строки
int n = 4;//столбца

void WriteArrayInt(int[,] massive)// метод принимает масив разделяет сиволы пробел
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(massive[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
WriteArrayInt(massive);
Console.WriteLine();

Console.WriteLine($"Cреднее арифметическое: \n");

for (int i = 0; i < n; i++)
{
    double arithmetic = 0;
    for (int j = 0; j < m; j++)
    {
        arithmetic += massive[j, i];
    }
    arithmetic = Math.Round(arithmetic / m, 2);
    Console.WriteLine($"столбца № {i+1} {arithmetic}");
}
Console.WriteLine();

// string? line = Console.ReadLine();                                      // присвоить строка line принятое значение