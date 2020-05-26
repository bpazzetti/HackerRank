using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation
{
    class NonDivisibleSubset
    {
        /*
    * Complete the 'nonDivisibleSubset' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts following parameters:
    *  1. INTEGER k
    *  2. INTEGER_ARRAY s
    */

        public static int nonDivisibleSubset(int k, List<int> s)
        {
            int[] remainders = new int[k];
            int count = 0;

            // Count the # of numbers that have each remainder
            for (int i = 0; i < s.Count; i++)
            {
                remainders[s[i] % k]++;
            }

            // Get our counts of each category
            for (int i = 1; i <= (k / 2); i++)
            {
                // if the remainders are the same (i.e. k / 2),
                // there can be only 1
                if (i == k - i)
                {
                    count++;
                    continue;
                }
                // Otherwise, add the remainder with the
                // highest count
                count += Math.Max(remainders[i], remainders[k - i]);
            }

            // If we had one or more evenly divisible numbers,
            // there can be only 1
            if (remainders[0] > 0)
                count++;

            return count;
        }

        public static void Main1(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            int result = nonDivisibleSubset(k, s);

            Console.WriteLine(result);
        }
    }
}
