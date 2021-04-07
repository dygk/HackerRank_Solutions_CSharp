using System;
using Xunit;

namespace HackerRank_Solutions_CSharp.Tests
{
    public class JumpingOnCloudsTest
    {
        [Theory]
        [InlineData("0 0 1 0 0 0 0 0 0 0 1 0", 12, 6)]

        public void ComputesCorrectResponse(string c, int n, int conNumber)
        {

            Assert.Equal(HackerRank_Solutions_CSharp.JumpingOnClouds.Solution.JumpingCloudsMinCount(c, n), conNumber);
        }
    }
}
