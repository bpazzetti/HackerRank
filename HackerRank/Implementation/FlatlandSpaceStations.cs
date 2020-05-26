using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Algorithms.Implementation
{
    class FlatlandSpaceStations
    {

        static void Main1(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);
            Array.Sort(c);
            int max = c[0];
            for (int i = 0; i < m - 1; i++)
            {
                max = Math.Max(max, (c[i + 1] - c[i]) / 2);
            }
            max = Math.Max(max, ((n - 1) - c[m - 1]));
            Console.WriteLine(max);
        }
    }
}