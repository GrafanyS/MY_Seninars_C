﻿/*
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

Console.Write("Введите число из пяти символов: ");   //Введите число
string? num = Console.ReadLine(); // Особенностью метода Console.ReadLine() является то, что он может считать информацию и присвоить строковое значение
                                  // с консоли только в виде строки

void Palindrom(string num)                            // Преобразование метода из void в string           
{
    if (num[0] == num[4] || num[1] == num[3])  //   Блок кода  проверки палиндрома сравниваем через индексы символов  
    {
        Console.WriteLine($"Ваше число: {num} - Палиндром.");   // выводим что ввели Палином
    }
    else Console.WriteLine($"Ваше число: {num} - НЕ палиндром.");   // иначе не палином
}

if (num!.Length == 5)                                           // Проверить число на длину 
{
    Palindrom(num);
}
else Console.WriteLine($"Вы ввели не пятисимвольное число, введите правильное число");  //  ругаемя  что ввели не число или не 5 символов
