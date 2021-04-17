using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Solutions_CSharp.NewYearChaos
{
    public static class NewYearChaos
    {
        public static void minimumBribes(int[] q)
        {
            int count = 0;
            bool isChoatic = false;

            for (int i = 0; i < q.Length; i++)
            {
                int bribeCount = q[i] - i + 1;
                if (bribeCount > 0)
                    count += bribeCount;

                if (bribeCount > 2)
                    isChoatic = true;
            }

            Console.WriteLine(isChoatic ? "Too Chaotic" : count);
        }

        public static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
                ;
                minimumBribes(q);
            }

        }
    }
}
