using System;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            int result = RomanParser.Parse("MCMXCIV");  // 1994
            Console.WriteLine(result);

        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}