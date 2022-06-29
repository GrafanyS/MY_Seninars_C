/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6


*/

Console.WriteLine("Введите трехзначное число:  ");

string? line = Console.ReadLine();
if (line != null) calc(line);
void calc(string cal)
{
    int numberLevel = cal.Length;
    if (numberLevel > 3)
    {
        int delitel = numberLevel - 3;                                  //Находим число для степени 10-ки
        ulong delitelNum = Convert.ToUInt64(Math.Pow(10, delitel));     //Получаем число на которое будем делить

        try                                                             // Блок кода, в котором возможно исключение
        {
            ulong number = Convert.ToUInt64(cal);                       // Получаем число
            ulong number1 = number / delitelNum;                        // От стартового числа отрезаем первые 3 порядка
            ulong result = number1 % 10;                            // Получаем остаток от 10 это 3 -я цифра
            Console.WriteLine("Третья цифра числа: " + result);                                  // Выводим значение в консоль
        }
        catch (FormatException)                                         // Блок кода - обработака исключений
        {
            Console.WriteLine("Ошибка. Вы ввели не число");             // ругаемя что ввели не число
        }
    }
    else if (numberLevel < 3)                                           // иначе обрабатываем исключение ввели меньше 3 цифр
    {
        Console.WriteLine("Ошибка. Нет третьего числа");                // ругаемя  что ввели не число 3 - х значное число

    }
    else if (numberLevel == 3)
    {
        try
        {
            int number = Convert.ToInt32(cal) % 10 ;                 // Получаем остаток от 10 это 3 -я цифра
            Console.WriteLine("Третья цифра числа: " + number);
        }
        catch (System.Exception)                                       // Блок кода - обработака исключений
        {

            throw;
        }
    }


}
