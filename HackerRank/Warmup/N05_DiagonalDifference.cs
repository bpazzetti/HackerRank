using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace HackerRank.Implementation
{
    class N05_DiagonalDifference
    {

        static int DiagonalDifference(int n, int[][] ar)
        {
            // Complete this function
            int resA = 0;
            int resB = 0;
            for (int i = 0; i < n; i++)
            {
                resA += ar[i][i];
                resB += ar[i][n - i - 1];
            }
            return Math.Abs(resA - resB);
        }

        static void Main1(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            int result = DiagonalDifference(n, a);
            Console.WriteLine(result);
        }
    }
}