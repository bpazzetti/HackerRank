using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace HackerRank.Implementation
{
    class DrawingBook
    {

        static int solve(int n, int p)
        {
            int fw = 0;
            int bk = 0;
            bk = (n / 2) - (p / 2);
            fw = (p / 2);
            /*Console.WriteLine("n={0}, p={1}, bk={2} fw={3}", n, p, bk, fw);*/
            return bk > fw ? fw : bk;
        }

        static void Main1(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            int result = solve(n, p);
            Console.WriteLine(result);
        }
    }
}