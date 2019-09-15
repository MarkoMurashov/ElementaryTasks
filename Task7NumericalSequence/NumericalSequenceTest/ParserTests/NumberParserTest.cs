using System;

using Xunit;
using NumericalSequence;

namespace NumericalSequenceTest
{
    public class NumberParserTest: IClassFixture<NumberParserFixture>
    {
        private readonly NumberParserFixture Sequnce;

        public NumberParserTest(NumberParserFixture sequence)
        {
            Sequnce = sequence;
        }
       
        [Theory]
        [InlineData("15", 15)]
        [InlineData("268",268)]
        public void Parse_WithStringNumber_ShouldReturnNumericNumber(string str, int expected)
        {
            var actual = Sequnce.SequenceFixture.Parse(str);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("-15")]
        [InlineData("10000")]
        public void Parse_ShouldThrowOutOfRahgeExp_When_NumebrIsOutOfRange (string str)
        {
            Assert.Throws<ArgumentOutOfRangeException>(()
                => Sequnce.SequenceFixture.Parse(str));
        }

        [Theory]
        [InlineData("daaaaaaaaaaaaaaaaaa")]
        [InlineData("10!!!000")]
        public void Parse_ShouldThrowFormatExp_When_NonNumericNumber(string str)
        {           
            Assert.Throws<FormatException>(()
                => Sequnce.SequenceFixture.Parse(str));
        }
    }
}
