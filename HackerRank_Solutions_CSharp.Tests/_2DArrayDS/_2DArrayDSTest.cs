using System;
using System.Collections.Generic;
using Xunit;

namespace HackerRank_Solutions_CSharp.Tests._2DArrayDS
{
    public class _2DArrayDSTest
    {

        [Theory]
        [MemberData(nameof(HourGlassData))]
        public void GetCorrectResponse(int[][] arr, int expected)
        {

            Assert.Equal(HackerRank_Solutions_CSharp._2DArrayDS.SolutionArray.hourglassSum(arr), expected);
        }

       

        public static IEnumerable<object[]> HourGlassData
        {
            get
            {
                yield return new object[] {    new int[6][] {new int[6] { 1, 1, 0, 0, 0, 0 },
                    new int[6] { 0, 1, 0, 0, 0, 0 },
                                        new int[6] { 1, 1, 1, 0, 0, 0 },
                                        new int[6] { 0, 0, 2, 4, 4, 0 },
                                        new int[6] { 0, 0, 0, 2, 0, 0},
                                        new int[6] { 0, 0, 1, 2, 4, 0 } } ,19  };
                yield return new object[] { new int[6][] {new int[6] {-1, -1, 0, -9, -2, -2 },
                                        new int[6] { -2, -1, -6, -8, -2, -5 },
                                        new int[6] { -1, -1, -1, -2, -3, -4 },
                                        new int[6] { -1, -9, -2, -4, -4, -5 },
                                        new int[6] { -7, -3, -3, -2, -9, -9 },
                                        new int[6] { -1, -3, -1, -2, -4, -5 } } , -6};
               
            }
        }
    }
}
