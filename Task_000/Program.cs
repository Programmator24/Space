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

string[] strings = new string [number];
FillArray(strings, number);