using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HackerRank.Implementation
{
    class RepeatedString
    {
        static void Main1(String[] args)
        {
            string s = Console.ReadLine();
            long n = Convert.ToInt64(Console.ReadLine());
            int count = Regex.Matches(Regex.Escape(s), "a").Count;
            long mod = n % s.Length;
            long div = n / s.Length;
            long res = count * div;
            /*Console.WriteLine(count);
            Console.WriteLine(mod);
            Console.WriteLine(div);
            Console.WriteLine(res);*/
            if (mod > 0)
                for (int i = 0; i < mod; i++)
                    if (s[i] == 'a')
                        res++;
            Console.WriteLine(res);

        }
    }
}