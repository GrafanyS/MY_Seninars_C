// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// array of real numbers => массив вещественных чисел

double[] arrayRealNumbers = new double[10];// генерируем 10 случайных чисел
for (int i = 0; i < arrayRealNumbers.Length; i++)
{
    arrayRealNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayRealNumbers[i] + " ");
}

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

for (int i = 1; i < arrayRealNumbers.Length; i++)//пробегаем циклом находя min и max
{
    if (maxNumber < arrayRealNumbers[i])
    {
        maxNumber = arrayRealNumbers[i];
    }
    if (minNumber > arrayRealNumbers[i])
    {
        minNumber = arrayRealNumbers[i];
    }
}

double decision = maxNumber - minNumber;//Находим разницу между max и min
Console.WriteLine();

Console.WriteLine($"разница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");//выводим в консоль значения
