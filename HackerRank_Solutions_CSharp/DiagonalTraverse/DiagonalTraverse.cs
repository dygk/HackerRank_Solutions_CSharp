using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Solutions_CSharp.DiagonalTraverse
{
    public class DiagonalTraverse
    {

        public static List<int>  resultArray;

        public static int[]  FindDiagonalOrder(int[][] matrix)
        {

            resultArray = new List<int>();
            resultArray.Add( matrix[0][0]);

            GoUp(matrix, 0,0 );


            return resultArray.ToArray();

    }

        private  static  void GoUp(int[][] matrix, int i, int j)
        {
            int m = matrix.GetLength(0);
            int n= matrix.GetLength(0);

            if (m-1== i && n-1== j)
                return;

           

            if (i-1 < 0 || j+1 >n-1)
            {  
                GoDown(matrix, i , j +1);
            }
            else
            {
                resultArray.Add(matrix[i][j]);
                GoUp(matrix, i - 1, j + 1);
            }
        }


        private static  void GoDown(int[][] matrix, int i, int j)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(0);

            if (m - 1 == i && n - 1 == j)
                return;

          

            if (i + 1 >m || j - 1 <0)
            {
                GoUp(matrix, i + 1, j );
            }
            else
            {
                resultArray.Add(matrix[i][j]);
                GoDown(matrix, i +1, j - 1);
            }
        }


        static void Main(string[] args)
        {

            //int[][] arr = new int[6][];


            int[][] arr = new int[3][] {new int[3] { 1, 2, 3},
                                        new int[3] { 4, 5, 6},
                                        new int[3] { 7, 8, 9},
                                       };
            //for (int i = 0; i < 6; i++)
            //{
            //    arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //}



            int[] result = FindDiagonalOrder(arr);

            Console.WriteLine(result);

        }
    }
}
