// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

//     1 4 7 2
//     5 9 2 3
//     8 4 2 4

//     1 7->такого числа в массиве нет

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)// метод генерации Random целых чисел
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue) + 1;

    return newArray;
}

void Show2dArray(int[,] array)// метод вывода значений рандомных чисел в 2-х мерный массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();

    }
}

string FindElement(int[,] value, int line, int column)//метод возвращает значение этого элемента
{
    if (line < value.GetLength(0) && column < value.GetLength(1))
    {
        return value[line, column].ToString();
    }
    else return "Такого элемента нет.";
}

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n}.");
Console.WriteLine();

int[,] myArray = CreateRandom2dArray(m, n, 1, 9);
Show2dArray(myArray);
Console.WriteLine();

Console.WriteLine(FindElement(myArray, 1, 2));
Console.WriteLine();
