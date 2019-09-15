using System;
using Xunit;
using System.Collections.Generic;
using NumericalSequence;
using Moq;

namespace NumericalSequenceTest
{
    public class SequenceGeneratorTest
    {
        [Fact]
        public void Create_ShouldReturnISequence()
        {
            var quadraticSequence = new Mock<ISequence>();
            SequenceGenerator sequence = new SequenceGenerator(quadraticSequence.Object);

            var actual = sequence.Create();

            Assert.IsAssignableFrom<IEnumerable<int>>(actual);
        }

        [Fact]
        public void CreateTest_ShouldThrowInvalidCustExp_When_NoISequenceObject()
        {
            var sequence = new SequenceGenerator(null);

            Assert.Throws<InvalidCastException>(()
                => sequence.Create());
        }
    }
}
