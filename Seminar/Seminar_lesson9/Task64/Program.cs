// Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.

//     N = 4532 -> 4

Console.Clear();

int Recur(int n)// метод рекурсивный
{
    return n < 10 ? 1 : 1 + Recur(n / 10);
}
void Print(string[] args)// метод вывода на печать
{
    Console.Write("Введите n=");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Recur(n));
    Console.ReadKey(true);
}

Print(args);

/*
int n = InputNumbers("Введите n: ");
int count = 2;
PrintNumber(n, count);
Console.Write(1);

void PrintNumber(int n, int count)
{
    if (count > n) return;
    PrintNumber(n, count + 1);
    Console.Write(count + ", ");
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
*/