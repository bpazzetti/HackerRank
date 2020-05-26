using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Algorithms.Warmup
{
    class N02_SimpleArraySum
    {

        static int simpleArraySum(int n, int[] ar)
        {
            // Complete this function
            int res = 0;
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
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = simpleArraySum(n, ar);
            Console.WriteLine(result);
        }
    }
}