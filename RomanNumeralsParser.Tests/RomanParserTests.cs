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
    
    public static int DigitValue(char romanDigit)
    {
        if (romanValues.TryGetValue(romanDigit, out int value))
        {
            return value;  
        }
        else
        {
            
            throw new ArgumentOutOfRangeException(nameof(romanDigit), $"Недопустимая римская цифра: {romanDigit}")
            {
                Source = "RomanNumber.DigitValue"  
            };
        }
    }
}