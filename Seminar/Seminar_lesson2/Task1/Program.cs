/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1


s = ( n % 100) / 10;
*/


// b = Convert.ToInt32(Console.ReadLine());
// c = Convert.ToInt32(Console.ReadLine());

// void SumOfNums(int twoNamber)
// {
//     // twoNamber = Console.WriteLine((numbers % 100) / 10);
//     twoNamber = Convert.ToInt32(Console.ReadLine());
//     // Console.WriteLine("Введите трех значное число : ");

//     int result = (twoNamber / 100 % 10);
//     if (result == Convert.ToInt32(Console.ReadLine())) ;
//     // return;
//     // int b = bc % 10;
//     // if (b > 0)
//     return;

//     // else return;
// }
// int namber;
// Console.WriteLine("Введите трех значное число : ");

// // number = Convert.ToInt32(Console.ReadLine());
// int twoNamber = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine((twoNamber % 100) / 10);

// int result = SumOfNums();
// Console.WriteLine("Вторая цифра из трехзначного числа:  " + result);

// void TwoNamber(int num)
// {
//     // int rand = new Random().Next(10, 100);

//     // Console.WriteLine("Curent random number is" + rand);

//     int dec = num % 100;
//     int ed = num / 10;
//     // if (dec > ed) 
//     return;
//     // else return ed;
// }
// Console.WriteLine("Введите трех значное число : ");
// int num = Convert.ToInt32(Console.ReadLine());
// int twoNum = TwoNamber();
// Console.WriteLine("Bigger  digit is " + twoNum);
/*
int TwoNamber()// Обявляю метод
{
    // int Firstnum, Secondnum, twoNum;

    int num = Convert.ToInt32(Console.ReadLine());
    int Firstnum = num % 100;// остаток
    int Lastnum = num / 10; //  цело численое деление на 10
    int twoNumber = Lastnum % 10; // Lastnum % 10)остаток от Lastnum 
    return twoNumber; // Возврат данных вычесления

}
Console.WriteLine("Введите трех значное число : ");  //ввод
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 100 || num >= 1000)
// {
//     string usingtext = Console.Write("Вы ввели не трехзначное число");
//     Console.ReadKey();
//     // break;
//     return;
// }


int result = TwoNamber();

Console.WriteLine("Выыод числ: ");
Console.WriteLine(result);


// if (num > 100 || num <= 1000)
// {
//     int Firstnum = num % 10;// остаток
//     int Lastnum = num / 10; //  цело численое деление на 10
//     int twoNumber = Lastnum % 10; // Lastnum % 10)остаток от Lastnum 
//     return twoNumber; // Возврат данных вычесления
// }
// else
// // bool equals = false;
// {
//     Console.Write("Вы ввели не трехзначное число");
//     string value = Console.ReadKey();
//     return value;
// }
*/

//Программа для получения 3-го элемента числа и вывод его на экран
Console.WriteLine("Введите число");

String number = Console.ReadLine();

if (number != null) Calculator(number);

void Calculator(String cal)                       //метод, который находит математическим путем 3-й элемент числа
{
    int levelNumberCount = cal.Length;            //получаем длину числа
    if (levelNumberCount > 3)                      //если число длиннее 3
    {
        int delitel = levelNumberCount - 3;                                //находим число для степени 10-ки
        ulong delitelNumber = Convert.ToUInt64(Math.Pow(10, delitel));    //получаем число на которое будем делить
        //Console.WriteLine(delitelNumber);
        try
        {
            ulong number = Convert.ToUInt64(cal);                              //получаем стартовое число
            ulong res = number / delitelNumber;                                //отрезаем от стартового первые 3 порядка
            ulong result = res % 10;                                           //получаем число как остаток от деления на 10
            Console.WriteLine(result);                                         //выводим на экран
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }                //если введены символы ругаемся


    }
    else if (levelNumberCount < 3)                                         //случай когда число поменьше
    {
        Console.WriteLine("нет третьего числа");
    }
    else                                                                   //когда число имеет 3 элемента.
    {
        try
        {
            int number = Convert.ToInt32(cal) % 10;
            Console.WriteLine(number);
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }            //если введены символы ругаемся

    }

}

// if (number != null) SubStringer(number);

void SubStringer(String s)                             // используем преимущества типа STRING
{
    if (s.Length >= 3)
    {
        try
        {
            String result = s.Substring(2, 1);         // создаем новую строку начиная с третьего символа, длиною в 1 символ.
            int res = Convert.ToInt32(result);         // переводим строку в число
            Console.WriteLine(res);                    // выводим на экран ответ
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }   // сообщаем пользователю, что введен некорректный формат данных
    }
    else Console.WriteLine("третьей цифры нет");      // сообщаем пользователю, что третьей цыфры нет

}


// if (number != null) Executor(number);

void Executor(String space)                            // метод вырезания нужной цыфры
{
    List<Char> list = new List<Char>();
    list = space.ToList();                             // переводим запись в список символов
    if (list.Count < 3)                                // когда нет 3го символа
    {
        Console.WriteLine("третьей цифры нет");
    }

    for (int i = 0; i < list.Count; i++)              // находим второй элемент
    {
        if (i == 2)
        {
            try
            {
                string re = list[i].ToString();            // обходим тут возможность конвертирования из CHAR в INT
                int ret = Convert.ToInt32(re);             // конвертируем строку в число                     
                Console.WriteLine(re);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }   // сообщаем пользователю, что введено не число
        }
    }
    list.Clear();        //уничтожаем список освобождая память
}
