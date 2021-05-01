using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank_Solutions_CSharp.Tests
{
    public class ReplaceAllDigitsWithCharsTest
    {
        [Theory]
        [InlineData("a1c1e1", "abcdef")]

        public void ComputesCorrectResponse(string c,  string correctResult)
        {

            Assert.Equal( ReplaceAllDigitsWithChars.ReplaceAllDigitsWithChars.ReplaceDigits(c), correctResult);
        }
    }
}
