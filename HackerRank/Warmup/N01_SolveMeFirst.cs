using System;
using System.Collections.Generic;
using System.IO;
namespace HackerRank.Warmup
{ 
class N01_SolveMeFirst {
    static int solveMeFirst(int a, int b) { 
      // Hint: Type return a+b; below
        return a+b;
      
    }
    static void Main1(String[] args) {
        int val1 = Convert.ToInt32(Console.ReadLine());
        int val2 = Convert.ToInt32(Console.ReadLine());
        int sum = solveMeFirst(val1,val2);
        Console.WriteLine(sum);
    }
}   
}