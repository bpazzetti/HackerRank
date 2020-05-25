using System;
using System.Collections.Generic;
using System.IO;
namespace HackerRank.Implementation
{
    class BeautifulDaysAtTheMovies
    {

        static int ReverseNumber(int n)
        {
            int result = 0;
            while (n > 0)
            {
                result = result * 10 + n % 10;
                n /= 10;
            }
            return result;
        }

        static void Main1(String[] args)
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int i = Convert.ToInt32(tokens_s[0]);
            int j = Convert.ToInt32(tokens_s[1]);
            int k = Convert.ToInt32(tokens_s[2]);
            int bd = 0;
            for (; i <= j; i++)
            {
                if (Math.Abs(i - ReverseNumber(i)) % k == 0)
                    bd++;
            }
            Console.WriteLine(bd);

        }
    }
}