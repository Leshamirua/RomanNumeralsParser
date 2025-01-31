using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumeralsParser.Tests
{
    [TestClass]
    public class RomanParserTests
    {
        [TestMethod]
        public void ParseTest_WithValidAndNonOptimalCases()
        {
            var validCases = new Dictionary<string, int>
            {
                { "I", 1 },
                { "II", 2 },
                { "III", 3 },
                { "IV", 4 },
                { "V", 5 },
                { "VI", 6 },
                { "VII", 7 },
                { "VIII", 8 },
                { "IX", 9 },
                { "X", 10 },
                { "XL", 40 },
                { "L", 50 },
                { "XC", 90 },
                { "C", 100 },
                { "CD", 400 },
                { "D", 500 },
                { "CM", 900 },
                { "M", 1000 },
                
                // Не оптимальные записи
                { "IIII", 4 },   
                { "VV", 10 },    
                { "XXXX", 40 },  
                { "LL", 100 },   
                { "CCCC", 400 }, 
                { "DD", 1000 },  
                { "MMMM", 4000 } 
            };

            foreach (var testCase in validCases)
            {
                int result = RomanParser.Parse(testCase.Key);  
                Assert.AreEqual(testCase.Value, result, $"Тест не пройден для {testCase.Key}");
            }
        }

        [TestMethod]
        public void ParseTest_WithErrorCases()
        {
            // testCases - строки с правильными и неправильными символами
            var testCases = new List<string>
            {
                "MCMXCIV",   // правильная строка
                "IIII",      // не оптимальная, но допустимая
                "IAXI",      // содержит ошибочный символ 'A'
                "123IV",     // содержит цифры
                "LXLX",      // неправильная строка
                "VXIYV"      // содержит ошибочный символ 'Y'
            };

            foreach (var testCase in testCases)
            {
                try
                {
                    int result = RomanParser.ParseWithErrors(testCase); 
                    Console.WriteLine($"Значение строки '{testCase}' = {result}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }
    }
}
