using System;
using Xunit;

namespace JsonValidatorForNumbers.Test
{
    public class ProgramTests
    {
        [Fact]
        public void FirstTestWhereTheMethodIsNotImplemented()
        {
            Program.ValidateJSONNumber("Test");
        }

        [Fact]
        public void For5TheExpectedReturnShouldBeTrue()
        {
            string input = "5";
            bool expected = true;
            bool actual = Program.ValidateJSONNumber(input);
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void ForMinus5TheExpectedReturnShouldBeTrue()
        {
            string input = "-5";
            bool expected = true;
            bool actual = Program.ValidateJSONNumber(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void For234TheExpectedReturnShouldBeTrue()
        {
            string input = "234";
            bool expected = true;
            bool actual = Program.ValidateJSONNumber(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ForMinus123TheExpectedReturnShouldBeTrue()
        {
            string input = "-123";
            bool expected = true;
            bool actual = Program.ValidateJSONNumber(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ForCommaNrsTheExpectedReturnShouldBeTrue()
        {
            string input = "12.34";
            bool expected = true;
            bool actual = Program.ValidateJSONNumber(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ForExponentialNrsTheExpectedReturnShouldBeTrue()
        {
            string input = "12.123e3";
            bool expected = true;
            bool actual = Program.ValidateJSONNumber(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ForExponentialNrsPlusANumberOfDigitsTheExpectedReturnShouldBeTrue()
        {
            string input = "12.123E+3";
            bool expected = true;
            bool actual = Program.ValidateJSONNumber(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ForNumbersWithScientificNotationTheExpectedReturnShouldBeTrue()
        {
            string input = "12.123E-2";
            bool expected = true;
            bool actual = Program.ValidateJSONNumber(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ForNumbersStartingWith0TheExpectedReturnShouldBeFalse()
        {
            string input = "012";
            bool expected = false;
            bool actual = Program.ValidateJSONNumber(input);
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void ForNumbersContainingEButNotReallyExponentialTheExpectedReturnShouldBeFalse()
        {
            string input = "12.123E";
            bool expected = false;
            bool actual = Program.ValidateJSONNumber(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ANumberWithNodigitsAfterTheCommaShouldBeFalse()
        {
            string input = "12.";
            bool expected = false;
            bool actual = Program.ValidateJSONNumber(input);
            Assert.Equal(expected, actual);
        }
    }
}
