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

        public static int[] FindDiagonalOrder(int[][] matrix)
        {

            resultArray = new List<int>();

            GoUp(matrix, 0,0 );

            return resultArray.ToArray();

    }

        private  static  void GoUp(int[][] matrix, int i, int j)
        {
            int m = matrix.Length;
            int n= matrix.GetLength(0);

            if (m - 1 == i && n - 1 == j)
            {
                resultArray.Add(matrix[i][j]); return;
            }


            if (i>= 0 && i<n && j>=0 && j<m)
            {
                resultArray.Add(matrix[i][j]);
            }

            if (i-1 < 0 || j+1 >n-1)
            {
                
                GoDown(matrix, i , j +1);
            }
            else
            {
           
                GoUp(matrix, i - 1, j + 1);
            }
        }


        private static  void GoDown(int[][] matrix, int i, int j)
        {
            int m = matrix.Length;
            int n = matrix.GetLength(0);

            if (m - 1 == i && n - 1 == j)
            {
                resultArray.Add(matrix[i][j]); return;
            }



            if (i >= 0 && i < n && j >= 0 && j < m)
            {
                resultArray.Add(matrix[i][j]);
            }


            if (i + 1 >m || j - 1 <0)
            {
                
                GoUp(matrix, i + 1, j );
            }
            else
            {
                
                GoDown(matrix, i +1, j - 1);
            }
        }


        static void Main(string[] args)
        {


            int[][] arr = new int[3][] {new int[3] { 1, 2, 3},
                                        new int[3] { 4, 5, 6},
                                        new int[3] { 7, 8, 9},
                                       };
        

            int[] result = FindDiagonalOrder(arr);


            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

           

        }
    }
}
