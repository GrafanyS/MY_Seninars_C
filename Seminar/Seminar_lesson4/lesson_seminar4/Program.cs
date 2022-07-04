/*
Напишите программу, которая принимает на вход число (А)
и выдаёт сумму чисел от 1 до А.

*/

/*
void FinStum()//  как не надо делать
{
    Console.WriteLine("input positive integr number: ");
    int a = Convert.ToInt32(Consoe.ReadLine());

    int current = 1, sum = 0;
    wile(current<=a)
    {
        sum+= current;
        current++;
    }
    Console.WriteLine("Sum is"+ sum);

}
FinStum();

*/
/*
void FinStum(int a) // как надо
{
    int current = 1, sum = 0;
    wile(current <= a);
    {
        sum += current;
        current++;
    }
    return sum;
}

Console.WriteLine("input positive integr number: ");
int a = Convert.ToInt32(Consoe.ReadLine());

Console.WriteLine("Sum is" + FinStum(num));
*/

/*
Напишите программу, которая принимает на вход число и 
выдаёт количество цифр в числе
*/

/*
Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

int main(int num)
{
    int digits = 0; // кол-во цифр
    while (num > 0)
    {
        digits++;
        num = num / 10;
    }
    return digits;
}
Console.WriteLine("Ответ: " +(main(num)));
*/

/*
Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N.
*/

/*

Console.WriteLine("input number: ");

int Composition(int a)//  как  надо делать
{
    int current = 1, proizv = 1;
    while (current <= a)
    {
        proizv = proizv * current;
        current++;
    }
    return proizv;


}

int n1 = Convert.ToInt32(Console.ReadLine());

int b = Composition(n1);
Console.WriteLine("Sum is" + b);

*/

/*
Напишите программу, которая принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.

*/

int stepen(int a, int b)
{
    int i = 1;
    int c = 1;
    while (i <= b)
    {
        c = c * a;
        i++;
    }
    return c;
}

Console.WriteLine("input number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int s = stepen(n1, n2);
Console.WriteLine("Получите число: " + s);