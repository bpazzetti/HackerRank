using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace HackerRank.Warmup
{
    class N06_PlusMinus
    {

        static void Main1(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            double pos = 0;
            double neg = 0;
            double zero = 0;

            for (int i = 0; i < n; i++)
            {
                pos += Convert.ToInt32(arr[i] > 0);
                neg += Convert.ToInt32(arr[i] < 0);
                zero += Convert.ToInt32(arr[i] == 0);
            }
            Console.WriteLine("{0:R}", pos / n);
            Console.WriteLine("{0:R}", neg / n);
            Console.WriteLine("{0:R}", zero / n);
        }
    }
}