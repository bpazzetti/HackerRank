using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h30DaysOfCode
{
    class Day06_LetsReview
    {
        public static void Main1(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int n = Convert.ToInt32(Console.ReadLine());
            string s1, s2, s;
            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine();
                s1 = "";
                s2 = "";
                for (int j = 0; j < s.Length; j++)
                {
                    if (j % 2 == 0 || j == 0)
                        s1 += s[j];
                    else
                        s2 += s[j];
                }
                Console.WriteLine("{0} {1}", s1, s2);
            }
        }
    }
}
