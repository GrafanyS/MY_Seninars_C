/*
// void SumOfNums(int n1, int n2)
int SumOfNums(int n1, int n2)// аргутенты вызываемые
{
    int sum = n1 + n2;
    return sum;
}



int namber1 = 5;
int namber2 = 8;
int result;

result = SumOfNums(namber1, namber2);
Console.WriteLine(result);
*/
/*
void SumOfNums(int n1, int n2)
{
    int sum = n1 + n2;
    Console.WriteLine("Sum of elements is " + sum);
}


int number1 = 5;
int number2 = 8;

SumOfNums(number1, number2);
*/



/*
Напишите программу, которая выводит случайное число
из отрезка [10, 99] и показывает наибольшую цифру числа.
*/

// Console.Clear();
/*
int FindBiggerDigit()
{
    int rand = new Random().Next(10, 100);
    Console.WriteLine("Curent random number is" + rand);

    int dec = rand / 10;
    int ed = rand % 10;
    if(dec>ed)return dec;
    else return ed;
}

int maxNum = FindBiggerDigit();
Console.WriteLine("Bigger  digit is " + maxNum);
*/


/*
Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого числа

2*10+5

*/

int findMaxNumber()// Обявляю метод
{
    int randomNum = new Random().Next(100, 1000); // предел рандома
    Console.WriteLine("Curent random number is " + randomNum); //Вывод рандомного чиса
    int Firstnum = randomNum / 100;// цело численое деление на 100
    int Lastnum = randomNum % 10; // остаток
    int MaxNumber = Firstnum * 10 + Lastnum; // Firstnum(2)*10+Lastnum(5) грубый пример
    return MaxNumber;
}
int result = findMaxNumber();

Console.WriteLine("Выыод числ: ");
Console.WriteLine(result);

/*
Напишите программу, которая будет принимать на вход 
два числа и выводить, является ли второе число
кратным первому. Если второе число не кратно числу
первому, то программа выводит остаток от деления.
*/
/*
void StartGet(int n1, int n2)
{
    if( n1%)
    // int number=Convert.ToInt32(Console.ReadLine());

}
*/

/*
Напишите программу, которая принимает на вход число
 и проверяет, кратно ли оно одновременно 7 и 23.
*/



