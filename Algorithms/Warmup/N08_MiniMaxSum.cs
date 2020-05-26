using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Algorithms.Warmup
{
    class N08_MiniMaxSum
    {

        static void Main1(String[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int n = arr.Length;
            long min = long.MaxValue;
            long max = long.MinValue;

            for (int i = 0; i < n; i++)
            {
                long sum = 0;
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                        sum += arr[j];
                }
                if (sum < min)
                    min = sum;
                if (sum > max)
                    max = sum;
            }
            string res = min.ToString() + " " + max.ToString();
            Console.WriteLine(res);
        }
    }
}