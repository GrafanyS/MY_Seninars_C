// Lesson 9
// Урок 9. Как не нужно писать код. Часть 3

// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int n)
{
    if (n > 1) ShowNums(n - 1);

    Console.Write(n + " ");
}
*
// (5)-> (4)->(3)->(2)->(1) wl(1)->(2) wl(2)->(3) wl(3)

ShowNums(5);
Console.WriteLine();
*/
/*

void ShowNums1(int n)
{
    if (n <= 1)
    {
        Console.Write(n + " ");
        ShowNums(n - 1);

    }

}

ShowNums1(5);
*/

// Напишите программу, которая будет принимать на вход число и возвращать 
// сумму его цифр.
/*
int SumOfDigits(int n)
{
    if (n >= 10)
    {
        return n % 10 + SumOfDigits(n/10);
    }
    else return n;
}

Console.WriteLine(SumOfDigits(1234));
*/
// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.

// void ShowNums(int n, int m)
// {
//     if (n < m) ShowNums(n, m - 1);

//     Console.Write(m + " ");
// }
// ShowNums(2, 15);

// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.

double Stepen(double a, double b)
{
    if (b > 0)
    {
        return a * Stepen(a, b - 1);
    }
    else if (b < 0)
    {
        return 1 / a * Stepen(a, b + 1);
    }
    else return 1;
}

Console.WriteLine(Stepen(2, -3));