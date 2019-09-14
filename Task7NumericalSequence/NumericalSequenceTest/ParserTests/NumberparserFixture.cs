using System;
using System.Collections.Generic;
using System.Text;
using NumericalSequence;
using Moq;
namespace NumericalSequenceTest
{
    public class NumberParserFixture
    {
        public ISequenceParser SequenceFixture { get; private set; }

        public NumberParserFixture()
        {
            SequenceFixture = new NumberParser(1000);
        }
    }
}
