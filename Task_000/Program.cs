// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых либо меньше либо равняется 3 символам.  

Console.WriteLine("Введите колличество слов");
int number = int.Parse(Console.ReadLine());

void FillArray(string[] str, int number)
{
    Console.WriteLine($"Введите {number} слов через Enter:");
        for (int i = 0; i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
            }
            
}

void SortArray(string[] str)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length < 4)
        {
            Console.WriteLine(str[i]);
        }
    }
}

string[] strings = new string [number];
FillArray(strings, number);

Console.WriteLine();
SortArray(strings);