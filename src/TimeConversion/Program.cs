using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Saat (hh): ");
        int hour = int.Parse(Console.ReadLine());
        Console.Write("Dakika (mm): ");
        int minute = int.Parse(Console.ReadLine());
        Console.Write("Saniye (ss): ");
        int second = int.Parse(Console.ReadLine());

        
        string militaryTime = ConvertTo24HourFormat(hour, minute, second);
        Console.WriteLine($"24 Saatlik Format: {militaryTime}");

      
        string amPmTime = ConvertTo12HourFormat(hour, minute, second);
        Console.WriteLine($"12 Saatlik Format: {amPmTime}");
    }

    static string ConvertTo24HourFormat(int hour, int minute, int second)
    {
        
        if (hour == 12)
        {
            hour = 0;
        }
        return $"{hour:D2}:{minute:D2}:{second:D2}";
    }

    static string ConvertTo12HourFormat(int hour, int minute, int second)
    {
        
        string period = "AM";
        if (hour >= 12)
        {
            period = "PM";
            if (hour > 12)
            {
                hour -= 12;
            }
        }
        else if (hour == 0)
        {
            hour = 12;
        }
        return $"{hour:D2}:{minute:D2}:{second:D2}{period}";
    }
}