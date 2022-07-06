void Elements()
{
    int c = 8;
    int[] array = new int[c];
    for (int i = 0; i < c; i++)
    {
        array[i] = new Random().Next(-1000, 1000);
        // Console.Write(array[i]);
        Console.Write(array[i] + " ");
        // Console.Write(Console.ReadLine());

    }
    return;

}
Elements();
Console.WriteLine();

int Print()
{
    int c = 8;
    int[] str = new int[c];
    Console.Write("[ ");
    for (int i = 0; i < c; i++) 
    {
        str[i] = new Random().Next(-1000, 1000);
        Console.Write( str[i] + " "); 
    }
    Console.Write("]");
    return c;
}
Print();
Console.WriteLine();

/*
void Random() // Random number generator
{
    int number = new Random().Next(1, 8);  // random
    int[] numbers = new int[number];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 100); // random number massive
    }
    var str = string.Join(", ", numbers);// random numbers are assigned to the value of str  
    Console.WriteLine("[" + str + "]");

}
Random(); //output of the Random method value

// void Print() // Print the Random method value
// {
//     var str = string.Join(", ", numbers);
//     Console.WriteLine("[" + str + "]");
// }
// Print();//output    of  RandomNum   Print

// Создал коментарии с Яндекс переводчиком.
*/