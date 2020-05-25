using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank.Implementation {
class SequenceEquation
    {
    static void Main1(string[] args) {
        int n  = Convert.ToInt32(Console.ReadLine());
        string[] p_temp = Console.ReadLine().Split(' ');
        int[] p = Array.ConvertAll(p_temp,Int32.Parse);
        
        for (int x = 0; x < n; x++) {
            int y =Array.IndexOf(p,Array.IndexOf(p, x+1)+1)+1;
            Console.WriteLine(y);
        }                        
    }
  }
}
