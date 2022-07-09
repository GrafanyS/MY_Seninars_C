// Напишите программу, которая будет преобразовывать десятичное число 
// в двоичное.

/*
string ChangeNumber(int number)
{
    string result = String.Empty;

    while (number >= 1)
    {
        result = number %2 + result;
        number /= 2; // анологично number = number / 2;
    }
    return result;
}
Console.WriteLine(ChangeNumber(10));

*/

// Напишите программу, которая перевернёт одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)



int[] CreateRandomArray(int saize, int min, int max)
{
    int[] array = new int[saize];

    for (int i = 0; i < saize; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;

}

void ShowArrays(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
    Console.WriteLine();

}

int[] perevernu(int[] array)
{
    for (int i = 0, j=array.Length -1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}

int[] myArray =CreateRandomArray(5,1,9);
ShowArrays(myArray);
ShowArrays(perevernu(myArray));









//Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник с сторонами такой длины.
// a < b + c

/*

bool Treugolnik(int arg1, int arg2, int arg3)
{
    // if (arg1 < arg2 + arg3 && arg2 < arg1 + arg3 && arg3 < arg2 + arg1)
    //     return false;
    return arg1 < arg2 + arg3 && arg2 < arg1 + arg3 && arg3 < arg2 + arg1;

}

Console.WriteLine("введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Treugolnik(a, b, c));

*/






//Не используя рекурсию, выведите первые N чисел Фибоначчи.
//Первые два числа Фибоначчи: 0 и 1.

/*

void ShowArrays(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
    Console.WriteLine();

}


int[] Fibonacci(int n, int a, int b)
{
    int[] fibonacci = new int[n];
    fibonacci[0] = a;
    fibonacci[1] = b;
    for (int i = 2; i < n; i++)
    {

        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
    }
    return fibonacci;
}
int[] myArray = Fibonacci(9, 0, 1);
ShowArrays(myArray);

*/