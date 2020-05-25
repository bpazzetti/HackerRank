using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Implementation
{
    static class FindDigits
    {
        static int findDigits(int n)
        {
            string str = n.ToString();
            int total = 0;
            for (int i = 0; i < str.Length; i++)
                if (str[i] != '0')
                    if (n % int.Parse(str[i].ToString()) == 0)
                        total++;
            return total;
        }

        public static void Main1(string[] args)
        {            
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = findDigits(n);

                Console.WriteLine(result);
            }
        }
    }
}
