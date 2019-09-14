using System;
using Xunit;
using NumericalSequence;

namespace NumericalSequenceTest
{
    public class CommandLineParserTest
    {
        [Theory]
        [InlineData(new string[] { }, Operation.ShowInstruction)]
        [InlineData(new string[] { "1" },Operation.Quadtratic)]
        public void GetOperationTest(string[] args, Operation expected)
        {
            var parser = new CommandLineParser(args);

            var actual = parser.GetOperation<Operation>();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetOperationTest_ThrowExp()
        {
            var parser = new CommandLineParser(new string[] { "1", "2", "3" });

            Assert.Throws<FormatException>(()
                => parser.GetOperation<Operation>());
        }
    }
}
