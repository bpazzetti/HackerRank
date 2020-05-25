using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Implementation
{
    /// <summary>
    /// @HackerRank. Can you complete the challenge? http://hr.gs/eau #programming
    /// </summary>
    static class UtopianTree
    {
        static int utopianTree(int n)
        {
            int res = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    res = res + 1;
                }
                else
                {
                    res = res * 2;
                }
            }
            return res;
        }
        static void Main1(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = utopianTree(n);

                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
