using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Solutions_CSharp.JumpingOnClouds
{
   public  static class Solution
    {
      public  static int JumpingCloudsMinCount(string cloudsString, int n)
        {
            int jumpCount = 0;
            string[] cloudsArray = cloudsString.Split(new char[0]);
            if (n > 3)
            {

                int currentIndex = 0;

                while (currentIndex < n - 1)
                {
                    if (currentIndex == n - 2)
                    {
                        currentIndex = currentIndex + 1;
                    }
                    else
                    {
                        if (int.Parse(cloudsArray[currentIndex + 2]) == 0)
                        {
                            currentIndex = currentIndex + 2;
                        }
                        else
                        {
                            currentIndex = currentIndex + 1;
                        }
                    }

                    jumpCount++;
                }


            }
            else
            {

                jumpCount = 1;
            }

            return jumpCount;

        }


        //static void Main(string[] args)
        //{


        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int n = Convert.ToInt32(Console.ReadLine().Trim());

        //    string cloudsString = Console.ReadLine();



        //    int result = JumpingCloudsMinCount(cloudsString, n);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();

        //}
    }
}
