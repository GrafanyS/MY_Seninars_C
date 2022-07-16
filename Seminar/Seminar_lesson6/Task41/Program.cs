// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();


Console.Write($"Введи число М(количество чисел): \n");
int size = Convert.ToInt32(Console.ReadLine());


int[] FillArray(int size)// метод принимает массив 
{
    int[] ints = new int[size];
    Console.Write("Введи число: \n");
    for (int i = 0; i < ints.Length; i++)
    {
        ints[i] = Convert.ToInt32(Console.ReadLine());
    }
    return ints;
}


int Comparison(int[] massiveNumbers)// метод определения больше 0
{
    int count = 0;
    for (int i = 0; i < massiveNumbers.Length; i++)
    {
        if (massiveNumbers[i] > 0) count++;
    }
    return count;
}



Console.WriteLine($"Введено чисел больше 0: {Comparison(FillArray(size))} ");

