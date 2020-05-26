using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation
{
    class ChocolateFeast
    {
        // Complete the chocolateFeast function below.
        static int chocolateFeast(int n, int c, int m)
        {
            int total = n / c;
            int wrappers = total;            
            while(wrappers >= m)
            {
                total += wrappers / m;
                wrappers = (wrappers / m) + (wrappers % m);
            }
            return total;
        }

        public static void Main1(string[] args)
        {            
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] ncm = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(ncm[0]);

                int c = Convert.ToInt32(ncm[1]);

                int m = Convert.ToInt32(ncm[2]);

                int result = chocolateFeast(n, c, m);

                Console.WriteLine(result);
            }            
        }
    }
}
