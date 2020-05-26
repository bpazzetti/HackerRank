using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Algorithms.Implementation
{
    class MinimumDistances
    {

        static void Main1(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] A_temp = Console.ReadLine().Split(' ');
            int[] A = Array.ConvertAll(A_temp, Int32.Parse);
            int min = Int32.MaxValue;
            int dif = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] == A[j])
                    {
                        dif = Math.Abs(i - j);
                        /*Console.WriteLine("dif={0}, i={1}, j={2}", dif, i, j);*/
                        if (dif < min)
                            min = dif;
                    }
                }
            }
            if (min == Int32.MaxValue)
                min = -1;
            Console.WriteLine(min);
        }
    }
}