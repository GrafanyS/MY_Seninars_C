// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] massive = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };//заднный масив

void WriteArrayInt(int[,] massive)// метод
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write(massive[i, j] + " ");
        }
        Console.WriteLine();
    }
}

WriteArrayInt(massive);

Console.WriteLine($"Cреднее арифметическое: \n");

double[] Mean(int[,] value)
{
    double[] mean = new double[value.GetLength(1)];
    for (int i = 0; i < value.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < value.GetLength(0); j++)
        {
            sum += value[j, i];
        }
        mean[i] = Math.Round((double)sum / value.GetLength(0), 2);

    }
    return mean;
}

PrintMasively(Mean(massive));

void PrintMasively(double[] value)
{
    for(int i = 0; i < value.Length; i++)
    {
        if(value[i].ToString().Length>2)
        Console.Write(value[i].ToString().Substring(0,3) + " ");
        else
        Console.Write(value[i].ToString() + " ");
    }
    
}
