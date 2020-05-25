using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace HackerRank.Implementation
{
    class SaveThePrisoner
    {

        static int saveThePrisoner(int n, int m, int s)
        {
            int p = (s + m - 1) % n;
            return p == 0 ? n : p;
        }

        static void Main1(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int m = Convert.ToInt32(tokens_n[1]);
                int s = Convert.ToInt32(tokens_n[2]);
                int result = saveThePrisoner(n, m, s);
                Console.WriteLine(result);
            }
        }
    }
}