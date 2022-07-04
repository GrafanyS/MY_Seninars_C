// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



void Random()
{
    int number = new Random().Next(1, 8);  // random
    int[] numbers = new int[number];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 100);
    }
    // Console.WriteLine(numbers);
    // Console.Write($"{numbers[i]} ");
    var str = string.Join(", ", numbers);
    Console.WriteLine("[" + str + "]");

}
Random();
