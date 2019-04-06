using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumbersConverter
{
    public class RomanNumeralConverter
    {
        public string TranslateToRomanNumeral(int numberToTranslate)
        {
            try
            {
                    int[] numbers = new int[] {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
                    string[] romanNumeralsAssociatedToNumber = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

                    var result = new StringBuilder();
                    for (var i = 0; i < numbers.Length; i++)
                    {
                        while (numberToTranslate >= numbers[i])
                        {
                            numberToTranslate -= numbers[i];
                            result.Append(romanNumeralsAssociatedToNumber[i]);
                        }
                    }
                    return result.ToString();
                }
            catch (Exception)
            {
                throw new InvalidInputException();
            }
        }
    }
}
