using System;

using Xunit;
using NumericalSequence;

namespace NumericalSequenceTest
{
    public class NumberParserTest
    {
        [Theory]
        [InlineData("15", 15)]
        [InlineData("268",268)]
        public void ParseTest(string str, int expected)
        {
            ISequenceParser parser = new NumberParser(1000);

            var actual = parser.Parse(str);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("-15")]
        [InlineData("10000")]
        public void ParseTest_ThrowExp(string str)
        {
            ISequenceParser parser = new NumberParser(1000);

            Assert.Throws<ArgumentOutOfRangeException>(()
                => parser.Parse(str));
        }

        [Theory]
        [InlineData("daaaaaaaaaaaaaaaaaa")]
        [InlineData("10!!!000")]
        public void ParseTest_ThrowFormatExp(string str)
        {
            ISequenceParser parser = new NumberParser(1000);

            Assert.Throws<FormatException>(()
                => parser.Parse(str));
        }
    }
}
