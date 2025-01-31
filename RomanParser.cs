using System;
using System.Collections.Generic;

public class RomanParser
{
    private static readonly Dictionary<char, int> romanValues = new Dictionary<char, int>
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };
    
    public static int Parse(string roman)
    {
        if (string.IsNullOrEmpty(roman))
            throw new ArgumentException("Римская строка не может быть пустой", nameof(roman));

        int total = 0;
        int prevValue = 0;
        
        for (int i = roman.Length - 1; i >= 0; i--)
        {
            char currentSymbol = roman[i];

            if (!romanValues.ContainsKey(currentSymbol))
                throw new ArgumentOutOfRangeException(nameof(roman), $"Недопустимая римская цифра: {currentSymbol}");

            int currentValue = romanValues[currentSymbol];

            if (currentValue < prevValue)
            {
                total -= currentValue;
            }
            else
            {
                total += currentValue;
            }

            prevValue = currentValue;
        }

        return total;
    }
    
    public static int ParseWithErrors(string roman)
    {
        if (string.IsNullOrEmpty(roman))
            throw new ArgumentException("Римская строка не может быть пустой", nameof(roman));
        
        List<string> errors = new List<string>();

        int total = 0;
        int prevValue = 0;
        
        for (int i = 0; i < roman.Length; i++)
        {
            char currentSymbol = roman[i];
            
            if (!romanValues.ContainsKey(currentSymbol))
            {
                errors.Add($"неправильная цифра '{currentSymbol}' в позиции {i}");
            }
            else
            {
                int currentValue = romanValues[currentSymbol];
                
                if (currentValue < prevValue)
                {
                    total -= currentValue;
                }
                else
                {
                    total += currentValue;
                }

                prevValue = currentValue;
            }
        }
        
        if (errors.Count > 0)
        {
            throw new ArgumentException(string.Join(", ", errors));
        }

        return total;
    }
}
