using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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
    }
}