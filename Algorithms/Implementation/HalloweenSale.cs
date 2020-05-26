using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation
{
    class HalloweenSale
    {
        static int howManyGames(int p, int d, int m, int s)
        {
            // Return the number of games you can buy
            int total = 0;
            int dis = d;
            int pbase = p;
            int count = 0;
            while (total + pbase <= s)
            {
                if(total + pbase <= s)
                {
                    count++;
                    total = total + pbase;
                }
                pbase -= d;
                if (pbase <= m)
                    pbase = m;                    
            }
            return count;
        }

        public static void Main1(string[] args)
        {            
            string[] pdms = Console.ReadLine().Split(' ');

            int p = Convert.ToInt32(pdms[0]);

            int d = Convert.ToInt32(pdms[1]);

            int m = Convert.ToInt32(pdms[2]);

            int s = Convert.ToInt32(pdms[3]);

            int answer = howManyGames(p, d, m, s);

            Console.WriteLine(answer);
        }
    }
}
