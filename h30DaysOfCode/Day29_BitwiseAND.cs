using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h30DaysOfCode
{
    class Day29_BitwiseAND
    {
        public static void Main1(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                if (((k-1) | k) > n &&(k%2==0))
                {
                    Console.WriteLine($"{k - 2}");
                }
                else
                {
                    Console.WriteLine($"{k - 1}");
                }                
            }
    }
    }
}
