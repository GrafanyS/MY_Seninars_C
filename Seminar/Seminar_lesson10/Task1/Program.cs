// Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.

// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1


string[] massive = { "qwe", "wer", "ert", "rty", "tyu" };

int MassiveCount(string[] massive)// метод который считает кол-во слов в массиве, начинающихся на гласную букву.
{
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i][0] == 'a' ||
            massive[i][0] == 'e' ||
            massive[i][0] == 'i' ||
            massive[i][0] == 'o' ||
            massive[i][0] == 'u' ||
            massive[i][0] == 'y')
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine(MassiveCount(massive));