using Xunit;
using System.Collections.Generic;
using NumericalSequence;


namespace NumericalSequenceTest
{
    public class QuadraticSequenceTest
    {
        [Theory]
        [MemberData(nameof(ArgumentsSequence))]
        public void GenerateSequenc_WithSequenceEndNumber_ShouldReturnSequence(int end, IEnumerable<int> expected)
        {
            var sequence = new QuadraticSequence(end);

            var actual = sequence.GenerateSequence();

            Assert.Equal(expected, actual);
        }

       public static IEnumerable<object[]> ArgumentsSequence =>
       new List<object[]>
       {
            new object[] { 10, new int[] { 1, 2, 3 } },
            new object[] { 250, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                                                11,12 ,13,14, 15} }
       };

    }
}
