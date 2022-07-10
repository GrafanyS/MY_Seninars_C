// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] numbers = new int[10]; // присваеваем переменную с заданным параметром в 10 чисел

void FillArray(int[] array, int min, int max) //метод Random генерации
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void WriteArray(int[] array) // метод вывода
{    
    var str = string.Join(", ", array);//  String.Join Метод  Сцепляет элементы указанного массива или элементы коллекции, помещая между ними заданный разделитель.
    Console.Write("[" + str + "]");
    Console.WriteLine();
}

int QuantityPositive(int[] array)// метод определения четного и подсчета сколько четных
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
        {
            quantity++;
        }
    }
    return quantity;
}

FillArray(numbers, 100, 1000);// генерируем числа от 100 до 999
WriteArray(numbers);// обрабатываеи и масив
Console.WriteLine();// пустая строка

int quantity = QuantityPositive(numbers);//присваеваем переменную количество из метода Количество Положительное
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}"); //выводим в консоль строку