using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Algorithms.Warmup
{
    class N07_Staircase
    {

        static void Main1(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string pat = "#";
            for (int i = 0; i < n; i++)
            {
                string line = "";
                for (int j = 0; j < n; j++)
                {
                    if (j >= n - i - 1)
                        line += pat;
                    else
                        line += " ";
                }
                Console.WriteLine(line);
            }

        }
    }
}