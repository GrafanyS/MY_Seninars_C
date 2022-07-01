/*
int FindQuart(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x > 0 && y > 0) return 2;
    if (x > 0 && y > 0) return 3;
    if (x > 0 && y > 0) return 4;
    if (x > 0 && y > 0) return 5;
}

Console.WriteLine("Input X coord: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coord: ");
int y = Convert.ToInt32(Console.ReadLine());

int quad = FindQuart(x, y);
if (quad == -1)
    Console.WriteLine("Point on the axis: ");
else

*/


/*
Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой
четверти (x и y).
*/



/*
double nam = Console.ReadKey();
{
    if (nam == 1) Console.WriteLine("Первая четверть");
    if (nam == 2) Console.WriteLine("Первая четверть");
    if (nam == 3) Console.WriteLine("Первая четверть");
    if (nam == 4) Console.WriteLine("Первая четверть");
}
Console.WriteLine("");
*/




/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт квадраты чисел от 1 до N

*/


/*

Math.Sqrt(n

*/

double Pifagor(double x1, double y1, double x2, double y2)
{
    double gipotenuza = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2)*(y1 - y2));
    return gipotenuza;
}


Console.Write("Input x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Answer is " + Pifagor(x1, y1, x2, y2));