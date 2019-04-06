using System;
using Xunit;

namespace RomanNumbersConverter.Tests
{
    public class Converting_numbers_to_roman_numeral
    {
        [Fact]
        public void number_1_should_translate_to_roman_numeral_I()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 1;
            var expectedResult = "I";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void number_5_should_translate_to_roman_numeral_V()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 5;
            var expectedResult = "V";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_9_should_translate_to_roman_numeral_IX()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 9;
            var expectedResult = "IX";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_12_should_translate_to_roman_numeral_XII()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 12;
            var expectedResult = "XII";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void number_16_should_translate_to_roman_numeral_XVI()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 16;
            var expectedResult = "XVI";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_29_should_translate_to_roman_numeral_XXIX()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 29;
            var expectedResult = "XXIX";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_44_should_translate_to_roman_numeral_XLIV()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 44;
            var expectedResult = "XLIV";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_45_should_translate_to_roman_numeral_XLV()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 45;
            var expectedResult = "XLV";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_68_should_translate_to_roman_numeral_LXVIII()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 68;
            var expectedResult = "LXVIII";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_83_should_translate_to_roman_numeral_LXXXIII()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 83;
            var expectedResult = "LXXXIII";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_97_should_translate_to_roman_numeral_XCVII()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 97;
            var expectedResult = "XCVII";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_99_should_translate_to_roman_numeral_XCIX()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 99;
            var expectedResult = "XCIX";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_500_should_translate_to_roman_numeral_D()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 500;
            var expectedResult = "D";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_501_should_translate_to_roman_numeral_DI()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 501;
            var expectedResult = "DI";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_649_should_translate_to_roman_numeral_DCXLIX()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 649;
            var expectedResult = "DCXLIX";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_798_should_translate_to_roman_numeral_DCCXCVIII()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 798;
            var expectedResult = "DCCXCVIII";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_891_should_translate_to_roman_numeral_DCCCXCI()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 891;
            var expectedResult = "DCCCXCI";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_1000_should_translate_to_roman_numeral_M()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 1000;
            var expectedResult = "M";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_1004_should_translate_to_roman_numeral_MIV()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 1004;
            var expectedResult = "MIV";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_1006_should_translate_to_roman_numeral_MVI()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 1006;
            var expectedResult = "MVI";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_1023_should_translate_to_roman_numeral_MXXIII()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 1023;
            var expectedResult = "MXXIII";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_2014_should_translate_to_roman_numeral_MMXIV()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 2014;
            var expectedResult = "MMXIV";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void number_3999_should_translate_to_roman_numeral_MMMCMXCIX()
        {
            //Arrange
            var translator = new RomanNumeralConverter();
            var input = 3999;
            var expectedResult = "MMMCMXCIX";
            //Act
            var actualResult = translator.TranslateToRomanNumeral(input);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
