using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Implementation
{
    static class AppendAndDelete
    {
        static string appendAndDelete(string s, string t, int k)
        {
            int commonLength = 0;
            string no = "No";
            string yes = "Yes";
            for (int i = 0; i < Math.Min(s.Length,t.Length); i++)
            {
                if (s[i] == t[i])
                    commonLength++;
                else
                    break;
            }

            if (s.Length + t.Length - 2 * commonLength > k)
                return no;
            if ((s.Length + t.Length - 2 * commonLength) % 2 == k % 2)
                return yes;
            if (s.Length + t.Length - k < 0)
                return yes;
            return no;
        }

        public static void Main1(string[] args)
        {            
            string s = Console.ReadLine();

            string t = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine());

            string result = appendAndDelete(s, t, k);

            Console.WriteLine(result);            
        }
    }
}
