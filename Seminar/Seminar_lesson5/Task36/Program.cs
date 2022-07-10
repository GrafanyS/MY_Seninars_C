// Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

Console.Write($"Введи количество элементов массива: ");
int numberElements = Convert.ToInt32(Console.ReadLine());

int RandomNumbers(int numberElements, int min, int max)
{
    int[] randomNumbers = new int[numberElements];
    int sumElements = 0;
    Console.Write("Получившийся массив: ");

    Console.Write("[");
    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = new Random().Next(min, max);// random генератор
        Console.Write(randomNumbers[i] + " ");// вставляем пробелы
        
        if (i % 2 != 1)//условие остаток от деления неравен 1
        {
            sumElements = sumElements + randomNumbers[i];// присваеваем переменную вычесления нечетные сумируем

        }

    }
    Console.Write("]");
    return sumElements;

}


int randomNumbers = RandomNumbers(numberElements, -10, 100);// присваеваем переменную randomNumbers в заданом пределе
Console.WriteLine();

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {randomNumbers}");

