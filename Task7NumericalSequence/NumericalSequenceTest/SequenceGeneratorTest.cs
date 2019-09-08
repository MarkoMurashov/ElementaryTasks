using System;
using Xunit;
using System.Collections.Generic;
using NumericalSequence;

namespace NumericalSequenceTest
{
    public class SequenceGeneratorTest
    {
        [Theory]
        [InlineData(10, new int[] { 1,2, 3})]
        [InlineData(250, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                                                11,12 ,13,14, 15})]
        public void CreateTest(int end, IEnumerable<int> expected)
        {
            SequenceGenerator sequence = new SequenceGenerator(new QuadraticSequence(end));

            var actual = sequence.Create();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CreateTest_ThrowExp()
        {
            SequenceGenerator sequence = new SequenceGenerator(null);

            Assert.Throws<InvalidCastException>(()
                => sequence.Create());
        }
    }
}
