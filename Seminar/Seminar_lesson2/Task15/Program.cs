/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет


*/


Console.WriteLine("Введите день недели, как число");              //Введите число

String number = Console.ReadLine();                               //Принимаем переменную на чтение

if (number != null) DayWeek(number);                              // Переменная не равняется NULL

void DayWeek(String day)                                          // метод проверки дня недели выходной рабочий или нерное значение
{
    try
    {
        var day1 = Convert.ToInt32(day);

        if (day1 <= 0 || day1 > 7)
        {
            Console.WriteLine("Вы ввели несуществующий день недели");
        }

        else if (day1 > 5 && day1 <= 7)
        {
            Console.WriteLine("Сегодня выходной");
        }

        else if (day1 > 7 && day1 <= 100000000)
        {
            Console.WriteLine("Вы ввели не верное значение");
        }
        else
        {
            Console.WriteLine("Рабочий день");
        }

    }
    
    catch (System.Exception)                                        // Блок кода - обработака исключений
    {
        Console.WriteLine("Ошибка. Вы ввели не число");             // ругаемя  что ввели не число
    }
        
    


}
