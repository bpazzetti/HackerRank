using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank.Implementation
{

    class BirthdayChocolate
    {

        static int solve(int n, int[] s, int d, int m)
        {
            int chocolate = 0;
            int sum;
            for (int i = 0; i < s.Length; i++)
            {
                sum = s[i];
                for (int j = i + 1; j < i + m && j < s.Length; j++)
                {
                    sum += s[j];
                }
                if (sum == d)
                    chocolate++;
            }
            return chocolate;
        }

        static void Main1(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            string[] tokens_d = Console.ReadLine().Split(' ');
            int d = Convert.ToInt32(tokens_d[0]);
            int m = Convert.ToInt32(tokens_d[1]);
            int result = solve(n, s, d, m);
            Console.WriteLine(result);
        }
    }
}