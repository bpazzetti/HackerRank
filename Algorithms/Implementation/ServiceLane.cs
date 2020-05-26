using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation
{
    class ServiceLane
    {
        // Complete the serviceLane function below.
        static int[] serviceLane(int[] width, int n, int[][] cases)
        {
            int[] res = new int[cases.Length];
            for (int i = 0; i < cases.Length; i++)
            {
                int x = cases[i][0];
                int y = cases[i][1];

                int min = int.MaxValue;

                for (int j = x; j <= y ; j++)
                {
                    if (min > width[j])
                        min = width[j];
                }
                res[i] = min;
            }
            return res;
        }

        public static void Main1(string[] args)
        {
            string[] nt = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nt[0]);

            int t = Convert.ToInt32(nt[1]);

            int[] width = Array.ConvertAll(Console.ReadLine().Split(' '), widthTemp => Convert.ToInt32(widthTemp))
            ;

            int[][] cases = new int[t][];

            for (int i = 0; i < t; i++)
            {
                cases[i] = Array.ConvertAll(Console.ReadLine().Split(' '), casesTemp => Convert.ToInt32(casesTemp));
            }

            int[] result = serviceLane(width,n, cases);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}
