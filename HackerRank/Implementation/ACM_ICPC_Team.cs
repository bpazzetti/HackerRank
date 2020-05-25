using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank.Implementation
{
    class ACM_ICPC_Team
    {

        static void Main1(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int p = Convert.ToInt32(tokens_n[0]);
            int t = Convert.ToInt32(tokens_n[1]);
            int[][] topics = new int[p][];
            for (int i = 0; i < p; i++)
            {
                int[] a = new int[t];
                string ctl = Console.ReadLine();
                for (int j = 0; j < ctl.Length; j++)
                    a[j] = Convert.ToInt32(ctl[j] + "");
                topics[i] = a;
            }

            int h = -1;
            int best = 0;

            for (int i = 0; i < topics.Length - 1; i++)
            {
                for (int j = i + 1; j < topics.Length; j++)
                {
                    int k = 0;
                    for (int x = 0; x < t; x++)
                    {
                        k += (topics[i][x] == 1 || topics[j][x] == 1) ? 1 : 0;
                    }
                    if (k > h)
                    {
                        h = k;
                        best = 1;
                    }
                    else if (k == h)
                    {
                        best += 1;
                    }
                }
            }

            Console.WriteLine(h);
            Console.WriteLine(best);
        }
    }
}