using System;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            int result = RomanParser.DigitValue('X');
            Console.WriteLine($"Значение римской цифры 'X' равно: {result}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}