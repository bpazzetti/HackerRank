using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Algorithms.Implementation
{
    class CatsAndAMouse
    {
        static void Main1(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string[] tokens_x = Console.ReadLine().Split(' ');
                int x = Convert.ToInt32(tokens_x[0]);
                int y = Convert.ToInt32(tokens_x[1]);
                int z = Convert.ToInt32(tokens_x[2]);
                if (Math.Abs(x - z) < Math.Abs(y - z))
                    Console.WriteLine("Cat A");
                else
                    if (Math.Abs(x - z) > Math.Abs(y - z))
                    Console.WriteLine("Cat B");
                else
                    Console.WriteLine("Mouse C");
            }
        }
    }
}