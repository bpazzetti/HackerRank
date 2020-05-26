using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Algorithms.Strings
{
    class BeautifulBinaryString
    {

        static int minSteps(int n, string B)
        {
            int count = 0;
            int pos = 0;
            while ((pos = B.IndexOf("010")) >= 0)
            {
                count++;
                B = B.Substring(0, pos + 2) + "1" + B.Substring(pos + 3);
            }
            return count;
        }

        static void Main1(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string B = Console.ReadLine();
            int result = minSteps(n, B);
            Console.WriteLine(result);
        }
    }
}