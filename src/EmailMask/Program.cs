using EmailMaskingApp;

public class Program
{
    public static void Main()
    {
        var masker = new EmailMasker();

        Console.WriteLine(masker.MaskEmail("cansussssssssss@hotmail.com", 2, '*', false)); // do************@hotmail.com
        Console.WriteLine(masker.MaskEmail("doga_kocak0623@hotmail.com", 2, '*', true));  // do****@hotmail.com
        Console.WriteLine(masker.MaskEmail("doga_kocak0623@hotmail.com", 3, '#', false)); // dog############@hotmail.com
        Console.ReadLine();
    }
}