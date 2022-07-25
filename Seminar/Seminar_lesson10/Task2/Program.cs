// Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}



string[] massive = { "qwe", "wer", "ert", "rty", "tyu", "yui" };

string[] MergeIndex(string[] massive)// метод объединяя элементы исходного массива попарно
{
    string[] Merge = new string[massive.Length / 2];
    for (int i = 0; i < massive.Length; i += 2)
    {
        Merge[i / 2] = massive[i] + massive[i + 1];
    }
    return Merge;
}

void PrintMassive(string[] mass)// метод вывода
{
    foreach (string massive in mass)
    {
        Console.WriteLine(massive);
    }
}

PrintMassive(MergeIndex(massive));