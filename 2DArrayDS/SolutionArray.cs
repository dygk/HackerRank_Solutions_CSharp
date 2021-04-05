using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Solutions_CSharp._2DArrayDS
{
    class SolutionArray
    {
        static int hourglassSum(int[][] arr)
        {

            int? result = null;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int subArrCount = 0;
                    for (int k = j; k < j + 3; k++)
                    {
                        subArrCount += arr[i][k] + arr[i + 2][k];
                    }
                    subArrCount += arr[i + 1][j + 1];


                    if (result == null || result.HasValue && subArrCount > result)
                        result = subArrCount;


                }

            }

            return result.HasValue ? result.Value : 0;
        }



        static void Main(string[] args)
        {

            //int[][] arr = new int[6][];


            int[][] arr = new int[6][] {new int[6] { 1, 1, 0, 0, 0, 0 },
                                        new int[6] { 0, 1, 0, 0, 0, 0 },
                                        new int[6] { 1, 1, 1, 0, 0, 0 },
                                        new int[6] { 0, 0, 2, 4, 4, 0 },
                                        new int[6] { 0, 0, 0, 2, 0, 0},
                                        new int[6] { 0, 0, 1, 2, 4, 0 } };
            //for (int i = 0; i < 6; i++)
            //{
            //    arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //}



            int result = hourglassSum(arr);
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
