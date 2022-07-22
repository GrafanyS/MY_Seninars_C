//Написать программу, которая выводит 
//первое встречное слово на заданную букву
//из массива строк
//Написать программу, которая выводит 
//первое встречное слово на заданную букву
//из массива строк

// string FindWorldByLetter(string[]words, char cymbol)
// {
//     for (int i = 0; i < words.Length; i++)

//         if (words[i].ToLower()[0] == Char.ToLower(cymbol)) return words[i];

//     return "Empty";

// }


// string[] names = { "Denis", "Andrew", "rs696", "Dmitrij " ,  "Ivan" };

// Console.WriteLine(FindWorldByLetter(names, 'a'));

// Console.WriteLine(names[1].ToLower());

// Написать программу, принимающую на вход массив строк и определяющую 
// кол-во слов с длиной не меньше 3 символов

// string[] names = { "Andrew", "Denis", "Dmitrij ", "Ivan" };

// int LongWords(string[] words)
// {
//     int count = 0;
//     for (int i = 0; i < words.Length; i++)

//         if (words[i].Length >= 3) count++;
//     return count;

// }

// Console.WriteLine((LongWords(names)));

// Написать программу, принимающую на вход два массива строк и генерирующую 
// новый массив, состоящий из попарно объединенных исходных элементов

string[] names = { "Andrew", "Denis", "Dmitrij ", "Ivan" };
string[] values = { "Graf", "Good", "John", "James" };

string[] Fio(string[] a, string[] b)
{
   string[] Fio = new string[a.Length];
   for (int i = 0; i < a.Length; i++)
   {
       Fio[i] = a[i] + " " + b[i];

   }
   return Fio;
}

void Print(string[] a)
{
   for (int i = 0; i < a.Length; i++)
       Console.WriteLine(a[i] + " ");

   Console.WriteLine();
}

Print(Fio(names, values));


