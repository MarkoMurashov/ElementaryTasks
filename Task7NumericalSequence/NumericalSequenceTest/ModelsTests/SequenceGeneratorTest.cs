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
        public void CreateTest()
        {
            var quadraticSequence = new Mock<ISequence>();
            SequenceGenerator sequence = new SequenceGenerator(quadraticSequence.Object);

            var actual = sequence.Create();

            Assert.NotNull(actual);
        }

        [Fact]
        public void CreateTest_ThrowExp()
        {
            var sequence = new SequenceGenerator(null);

            Assert.Throws<InvalidCastException>(()
                => sequence.Create());
        }
    }
}
