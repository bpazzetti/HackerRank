using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Algorithms.Implementation
{
    class DivisibleSumPairs
    {

        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int res = 0;
            for (int i = 0; i < ar.Length - 1; i++)
            {
                for (int j = i + 1; j < ar.Length; j++)
                {
                    /*Console.WriteLine("i={0}, j={1}, ar[i]={2}, ar[j]={3}", i, j, ar[i], ar[j]);*/
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        res++;
                    }

                }
            }
            return res;
        }

        static void Main1(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = divisibleSumPairs(n, k, ar);
            Console.WriteLine(result);
        }
    }
}