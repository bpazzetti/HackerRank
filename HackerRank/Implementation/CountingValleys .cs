using System;
using System.Collections.Generic;
using System.IO;

namespace Algorithms.Implementation
{
    class CountingValleys
    {
        static void Main1(String[] args)
        {
            long n = Convert.ToInt64(Console.ReadLine());
            string s = Console.ReadLine();
            int level = 0;
            char step = ' ';
            int valley = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'U')
                {
                    level++;
                    step = 'U';
                }
                else
                {
                    level--;
                    step = 'D';
                }
                if (level == 0 && step == 'U')
                    valley++;
            }
            Console.WriteLine(valley);
        }
    }
}