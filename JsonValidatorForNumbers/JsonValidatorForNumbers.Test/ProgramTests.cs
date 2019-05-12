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
    }
}
