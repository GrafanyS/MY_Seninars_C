int n1, n2, quad;


Console.Write("Input first namber: ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second namber: ");
n2 = Convert.ToInt32(Console.ReadLine());

quad = n2 * n2;

if (quad == n1)
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}





class MyProgram
{
    static void Main()
    {
        int number;
        string txt;
        try
        {
            Console.WriteLine("Введите число от 1 до 7 включительно");

            number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    txt = "понедельник";
                    break;
                case 2:
                    txt = "вторник";
                    break;
                case 3:
                    txt = "среда";
                    break;
                case 4:
                    txt = "четверг";
                    break;
                case 5:
                    txt = "пятница";
                    break;
                case 6:
                    txt = "суббота";
                    break;
                case 7:
                    txt = "воскресение";
                    break;
                default:
                    txt = "некорректное значение";
                    break;
            }
            Console.WriteLine(txt, "День недели");
        }
        catch
        {
            Console.WriteLine("Вы не ввели число", "Ошибка");
            Console.WriteLine("Завершение программы");
        }
    }
}
// дни недели.









