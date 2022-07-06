// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число N: "); // Введите числовое значение
int numberN = Convert.ToInt32(Console.ReadLine());// Преобразуйте число в значение int и верните его как значение int

int SumNumber(int numberN)// метод который принимает чисо и выдает сумму в числе.
{

    int counter = Convert.ToString(numberN).Length;// Присваиваем числовое значение получаем длину числа
    int advance = 0;//Присваем значение локальной переменной
    int result = 0;//Присваем значение локальной переменной

    for (int i = 0; i < counter; i++)// метод
    {
        advance = numberN - numberN % 10;// Получаем остаток от 1 до N   
        result = result + (numberN - advance);//Получаем числовое значение result
        numberN = numberN / 10;// Получаем целое
    }
    return result;// возвращаем result
}

int sumNumber = SumNumber(numberN);// Присваем значение локальной переменной
Console.WriteLine("Сумма цифр в числе: " + sumNumber);