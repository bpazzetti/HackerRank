using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace HackerRank.Strings
{
    class CamelCase
    {

        static void Main1(String[] args)
        {
            string s = Console.ReadLine();
            int count = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}