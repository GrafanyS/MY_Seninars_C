// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



void Random() // Random number generator
{
    int number = new Random().Next(1, 8);  // random
    int[] numbers = new int[number];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 100); // random number massive
    }
    // Console.WriteLine(numbers);
    // Console.Write($"{numbers[i]} ");
    var str = string.Join(", ", numbers);// random numbers are assigned to the value of str  
    Console.WriteLine("[" + str + "]");

}
Random(); //output of the Random method value

// Создал коментарии с Яндекс переводчиком.
