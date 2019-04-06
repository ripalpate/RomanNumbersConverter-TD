using System;

namespace RomanNumbersConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number between 0 and 3999");
            var input = Console.ReadLine();
            var convertedInputToNumber = Convert.ToInt16(input);
            try
            {
                if (0 >= convertedInputToNumber || convertedInputToNumber > 4000) throw new InvalidInputException();
                var ConvertToRoman = new RomanNumeralConverter();
                var result = ConvertToRoman.TranslateToRomanNumeral(convertedInputToNumber);
                Console.WriteLine($"Roman number is {result}");
                Console.ReadLine();
            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
