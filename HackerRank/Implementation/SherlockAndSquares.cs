using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Implementation
{
    static class SherlockAndSquares
    {
        static int squares(int a, int b)
        {
            int total = 0;
            int min =int.Parse(Math.Ceiling(Math.Sqrt(a)).ToString());
            int max = int.Parse(Math.Floor(Math.Sqrt(b)).ToString());

            for (int i = min; i <= max ; i++)
            {
                total++;
            }

            return total++;
        }

        public static void Main1(string[] args)
        {           
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] ab = Console.ReadLine().Split(' ');

                int a = Convert.ToInt32(ab[0]);

                int b = Convert.ToInt32(ab[1]);

                int result = squares(a, b);

                Console.WriteLine(result);
            }
        }
    }
}
