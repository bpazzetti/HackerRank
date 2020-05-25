using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace HackerRank.Implementation
{
    class Kangaroo
    {

        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            /*jump = (x2-x1)/(v1-v2)*/
            if (v1 == v2 && x1 != x2)
                return "NO";
            int div = (x2 - x1) / (v1 - v2);
            int mod = (x2 - x1) % (v1 - v2);
            /*Console.WriteLine("x1={0}, x2={1}, v1={2}, v2={3}, div={4}, mod={5}", x1, x2, v1, v2, div, mod);*/
            return mod == 0 && div > 0 ? "YES" : "NO";
        }

        static void Main1(String[] args)
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);
            string result = kangaroo(x1, v1, x2, v2);
            Console.WriteLine(result);
        }
    }
}