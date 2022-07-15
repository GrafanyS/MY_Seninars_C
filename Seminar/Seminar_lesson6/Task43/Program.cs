// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.WriteLine($"Введите данные для уравнений по пересечению 2 прямых \nПрямая определяется уравнением y=x*K + b ");
Console.WriteLine("Введите K1 первой прямой");

try
{
    int K1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите b1 первой прямой");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите K2 первой прямой");
    int K2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите b2 первой прямой");
    int b2 = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine(Сrossroad(K1, b1, K2, b2));

}
catch (Exception ex) { Console.WriteLine(ex.Message); }


String Сrossroad(double nK1, double nb1, double mK2, double mb2)
{
    double x = (double)(nb1 - mb2) / (mK2 - nK1);
    double y = nK1 * x + nb1;
    return "(" + x + ", " + y + ")";
}
