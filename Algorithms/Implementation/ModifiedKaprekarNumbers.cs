using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation
{
    class ModifiedKaprekarNumbers
    {
        // Complete the kaprekarNumbers function below.
        static void kaprekarNumbers(int p, int q)
        {
            string result = string.Empty;
            int l;
            int r;
            for (long i = p; i <= q; i++)
            {
                l = 0;
                r = 0;
                long square = i * i;
                int digits = i.ToString().Length;
                string s = square.ToString();
                r = int.Parse(s.Substring(s.Length - digits));
                if (digits < s.Length)
                {
                    l = int.Parse(s.Substring(0, s.Length - digits));
                }

                /*l = int.Parse(s.Substring(0, digits));
                if (digits < s.Length)
                    r = int.Parse(s.Substring(digits));
                */
                if (l + r == i)
                    result += i.ToString() + " ";
            }
            if (string.IsNullOrWhiteSpace(result))
                result = "INVALID RANGE";

            Console.WriteLine(result.Trim());

        }

        public static void Main1(string[] args)
        {
            int p = Convert.ToInt32(Console.ReadLine());

            int q = Convert.ToInt32(Console.ReadLine());

            kaprekarNumbers(p, q);
        }
    }
}
