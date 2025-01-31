using System;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            // int result = RomanParser.Parse("MCMXCIV");  // 1994
            int result = RomanParser.ParseWithErrors("VXIYV");  // строка с ошибкой
            Console.WriteLine($"Результат: {result}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

    }
}