using System;

class Program
{
    static void Main()
    {
        int aliceScore = 0;
        int bobScore = 0;

        Console.WriteLine("a's numbers:");

        Console.Write("First number : ");
        int a1 = int.Parse(Console.ReadLine());

        Console.Write("Second number: ");
        int a2 = int.Parse(Console.ReadLine());

        Console.Write("Third number: ");
        int a3 = int.Parse(Console.ReadLine());

        Console.WriteLine("\nb'S numbers:");

        Console.Write("First number: ");
        int b1 = int.Parse(Console.ReadLine());

        Console.Write("Second number: ");
        int b2 = int.Parse(Console.ReadLine());

        Console.Write("Third number: ");
        int b3 = int.Parse(Console.ReadLine());


        Console.WriteLine("\na's numbers: ");
        Console.WriteLine($"First number: {a1}");
        Console.WriteLine($"Second number: {a2}");
        Console.WriteLine($"Third number: {a3}");

        Console.WriteLine("\nb's numbers: ");
        Console.WriteLine($"First number: {b1}");
        Console.WriteLine($"Second number: {b2}");
        Console.WriteLine($"Third number: {b3}");


        if (a1 > b1) aliceScore++;
        else if (a1 < b1) bobScore++;

        if (a2 > b2) aliceScore++;
        else if (a2 < b2) bobScore++;

        if (a3 > b3) aliceScore++;
        else if (a3 < b3) bobScore++;

        Console.WriteLine($"\nAlice's score: {aliceScore}");
        Console.WriteLine($"Bob's score: {bobScore}");


    }
}