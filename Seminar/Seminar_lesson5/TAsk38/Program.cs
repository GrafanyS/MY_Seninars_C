// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// array of real numbers => массив вещественных чисел


/*
double[] arrayRealNumbers = new double[10];// генерируем 10 случайных чисел
for (int i = 0; i < arrayRealNumbers.Length; i++)
{
    arrayRealNumbers[i] = (new Random().Next(1, 10))+(new Random().NextDouble());
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
*/


Console.WriteLine("Введите длину масива: ");
int count = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите min число: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите max число: ");
int max = Convert.ToInt32(Console.ReadLine());



double[] arrayRealNumbers(int count, int min, int max)
{
    double[] array = new double[count];

    for (int i = 0; i < count; i++)
    {
        array[i] = (new Random().Next(min, max + 1)) + (new Random().NextDouble());        
    }
    return array;
    
}

void ShowArrays(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");        
    }
    Console.WriteLine();
}

double SumOfNums(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 1; i < array.Length; i++)//пробегаем циклом находя min и max
    {
        if (max < array[i])
        {
            max = array[i];
        }
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return max - min;
    


}

double[] MyArray = arrayRealNumbers(count, min, max);
ShowArrays(MyArray);
Console.WriteLine();



Console.WriteLine("разница между между максимальным и минимальным " + SumOfNums(MyArray));