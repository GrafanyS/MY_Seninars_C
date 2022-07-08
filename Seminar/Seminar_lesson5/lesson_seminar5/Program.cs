// Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите сумму отрицательных
// и положительных элементов массива.



int[] CreateRandomArray(int saize, int min, int max)
{
    int[] array = new int[saize];

    for (int i = 0; i < saize; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;

}



void ShowArrays(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        
    }
    Console.WriteLine();

}

int FindPosiveSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) sum += array[i];
    return sum;
}


int[] myArray = CreateRandomArray(10, 1, 9);
ShowArrays(myArray);
Console.WriteLine("sum of proizve elements is" + FindPosiveSum(myArray));




// Напишите программу замена элементов массива: положительные
// элементы замените на соответствующие отрицательные, и наоборот.

// int[] array = CreateRandomArray(10, -10, 10);
int[] m(int[] array)
{
    
    for (int i = 1; i < array.Length; i++)
    {
        array[i] = array[i * (-1)];
    }
    return array;
}


Console.WriteLine("Введите массив: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите min: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] mas = CreateRandomArray(size, min, max);

ShowArrays(m(mas));






// Задайте массив.Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.




// Задайте массив из 20 случайных чисел.
//  Найдите количество элементов массива, значения которых лежат 
// в отрезке [10,99].



