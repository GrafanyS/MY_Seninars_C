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
{
    static void Main(string[] args)
    {
        int N, x, y;
        string data = "data.txt";
        StreamReader sr = new StreamReader(data);
        int[] M = new int[4];  // число точек в каждом квадранте
        int[] R = new int[4];  // минимальное расстояние до оси
        int[] xA = new int[4]; // координаты искомых точек
        int[] yA = new int[4];
        for (int i = 0; i < 4; i++)
        {
            M[i] = 0;
            R[i] = 0;
        }
        int k;
        N = Convert.ToInt32(sr.ReadLine());
        for (int i = 0; i < N; i++)
        {
            // извлечение координат очередной точки           
            string xy = sr.ReadLine();
            int z = xy.IndexOf(' ');
            x = Convert.ToInt32(xy.Substring(0, z));
            y = Convert.ToInt32(xy.Substring(z + 1));
            // номер квадранта
            k = 0; // если лежит на оси х или у
            if (x > 0 & y > 0)
                k = 1;
            if (x < 0 & y > 0)
                k = 2;
            if (x < 0 & y < 0)
                k = 3;
            if (x > 0 & y < 0)
                k = 4;
            // анализ расстояния
            if (k > 0)
            {
                M[k - 1]++;
                if ((Math.Min(Math.Abs(x), Math.Abs(y)) < R[k - 1]) | R[k - 1] == 0)
                {
                    R[k - 1] = Math.Min(Math.Abs(x), Math.Abs(y));
                    xA[k - 1] = x;
                    yA[k - 1] = y;
                }
            }
        }
        // Точка с минимальным расстоянием 
        k = 0;
        for (int i = 1; i < 4; i++)
            if ((M[i] > M[k]) | ((M[i] == M[k]) & (R[i] < R[k])))
                k = i;
        // Результаты  
        Console.WriteLine("K = {0}", k + 1);
        Console.WriteLine("M = {0}", M[k]);
        Console.WriteLine("A = ({0},{1})", xA[k], yA[k]);
        Console.WriteLine("R = {0}", R[k]);
        Console.ReadKey();
    }
}
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
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Answer is " + Pifagor(x1, y1, x2, y2));