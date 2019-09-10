﻿using System;
using Xunit;
using System.Collections.Generic;
using NumericalSequence;

namespace NumericalSequenceTest
{
    public class ApplicationTest
    {
        [Theory]
        [InlineData("15", "1, 2, 3")]
        [InlineData("26", "1, 2, 3, 4, 5")]
        [InlineData("260", "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16")]
        public void ParseTest(string str, string expected)
        {
            Application app = new Application(null, null);

            var actual = app.GetQuadratic(str);

            Assert.Equal(expected, actual);
        }
    }
}