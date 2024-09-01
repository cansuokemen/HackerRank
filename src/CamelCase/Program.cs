using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir metin girin:");
        string input = Console.ReadLine();
        int camelCaseCount = CountCamelCaseWords(input);
        Console.WriteLine($"CamelCase kelime sayısı: {camelCaseCount}");
    }

    static int CountCamelCaseWords(string input)
    {
        if (string.IsNullOrEmpty(input)) return 0;


        int count = 1;

        foreach (char c in input)
        {
            if (char.IsUpper(c))
            {
                count++;
            }
        }

        return count;
    }
}