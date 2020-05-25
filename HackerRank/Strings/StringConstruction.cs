using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace HackerRank.Strings
{
    class StringConstruction
    {

        public static void WriteArray<T>(IEnumerable<T> array) { Console.WriteLine(string.Join(" ", array)); }

        static int stringConstruction(string s)
        {
            //int paid = 0;        
            int fLength = s.Length;
            int count = 0;
            var arrFirst = new int[26];

            for (int i = 0; i < fLength; i++)
            {
                arrFirst[s[i] - 'a']++;
            }
            //WriteArray(arrFirst);
            for (int i = 0; i < 26; i++)
            {
                if (arrFirst[i] != 0)
                    count++;
            }
            return count;
        }

        static void Main1(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                int result = stringConstruction(s);
                Console.WriteLine(result);
            }
        }
    }
}