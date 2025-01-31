using System;

public class RomanParser
{
    public static int DigitValue(char romanDigit)
    {
        switch (romanDigit)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default:
                throw new ArgumentOutOfRangeException(nameof(romanDigit), $"Недопустимая римская цифра: {romanDigit}")
                {
                    Source = "RomanNumber.DigitValue"  
                };
        }
    }
}