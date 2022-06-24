/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        int i;

        Console.Write("Введите число : ");

        i = int.Parse(Console.ReadLine());

        if (i % 2 == 0)

        {

            Console.Write("Введенное число является четным");

            Console.Read();

        }

        else

        {

            Console.Write("Введенное число нечетное");

            Console.Read();
        }
    }
}