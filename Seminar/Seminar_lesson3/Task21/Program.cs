/*

Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

*/

int x1 = Coordinate("x", "A"); 
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorNum, string dotNum)
{
    Console.WriteLine();
    Console.WriteLine($"Ваше число {coorNum} точки {dotNum}:");
    return Convert.ToInt32(Console.ReadLine());
}

double Decision(double x1, double x2, double y1, double y2, double z1, double z2)  // число со значениями от отрицательного до полжительног
                                                                                   // по точкам
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2)) +
    Math.Pow((y2 - y1), 2) +
    Math.Pow((z2 - z1), 2); // возводим в квадраты слаживаем и вычесляем корень, Math.Pow функция возведения, Math.Sqrt функция корня,
    // упрощенный вид Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2)*(y1 - y2))
}

double dotLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);//Округляет значение с плавающей запятой двойной точности до ближайшего целого значения
Console.WriteLine($"Ваша длина отрезка {dotLength}");
