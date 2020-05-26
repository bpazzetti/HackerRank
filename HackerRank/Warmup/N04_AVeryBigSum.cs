using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Algorithms.Warmup
{
    class N04_AVeryBigSum
    {

        static long aVeryBigSum(int n, long[] ar)
        {
            // Complete this function
            long res = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                res += ar[i];
            }
            return res;
        }

        static void Main1(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            long[] ar = Array.ConvertAll(ar_temp, Int64.Parse);
            long result = aVeryBigSum(n, ar);
            Console.WriteLine(result);
        }
    }
}