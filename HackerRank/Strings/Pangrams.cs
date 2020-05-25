using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank.Strings {
class Pangrams
    {
    static void Main1(string[] args) {
        string s = Console.ReadLine().ToLower();
        int[] abc = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            int ch = s[i] - 'a'; 
            if (ch >=0 && ch < 26)
                abc[ch]++;
        }
        
        bool res = true;
        
        for (int i = 0; i < 26; i++)
            if (abc[i] == 0)
            {
                res = false;
                break;
            }
        if (res)
            Console.WriteLine("pangram");
        else
            Console.WriteLine("not pangram");
    }
}
}
