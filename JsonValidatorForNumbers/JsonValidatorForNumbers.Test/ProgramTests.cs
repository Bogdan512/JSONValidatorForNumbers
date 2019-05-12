using System;
using Xunit;

namespace JsonValidatorForNumbers.Test
{
    public class ProgramTests
    {
        [Fact]
        public void FirstTestWhereTheMethodIsNotImplemented()
        {
            Program.ValidateJSONNumber();
        }

        [Fact]
        public void FirstGreenTestMinimumImplementation()
        {
            bool expected = true;
            bool actual = Program.ValidateJSONNumber();
            Assert.Equal(expected,actual);
        }
    }
}
