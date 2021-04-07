using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Solutions_CSharp.MiniMaxSum
{
    class MiniMaxSumSolution
    {

        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr)
        {
            long minSum = 0;
            long maxSum = 0;

            Array.Sort(arr);

            minSum = arr.AsParallel().Sum(x=> (long)x) - arr[4];

            Array.Reverse(arr);

            maxSum = arr.AsParallel().Sum(x => (long)x) - arr[4];

            Console.WriteLine(minSum + "  " + maxSum);
        }

        //static void Main(string[] args)
        //{
        //    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        //    ;
        //    miniMaxSum(arr);
        //}



    }
}
