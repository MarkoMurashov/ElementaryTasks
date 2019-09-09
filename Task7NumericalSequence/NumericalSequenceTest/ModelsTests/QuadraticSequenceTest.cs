using Xunit;
using System.Collections.Generic;
using NumericalSequence;


namespace NumericalSequenceTest
{
    public class QuadraticSequenceTest
    {
        [Theory]
        [InlineData(10, new int[] { 1, 2, 3 })]
        [InlineData(250, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                                                11,12 ,13,14, 15})]
        public void GenerateSequenceTest(int end, IEnumerable<int> expected)
        {
            QuadraticSequence sequence = new QuadraticSequence(end);

            var actual = sequence.GenerateSequence();

            Assert.Equal(expected, actual);
        }
     
    }
}
