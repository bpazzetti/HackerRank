using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank.BitManipulation
{
    class TheGreatXOR
    {

        static long theGreatXor(long x)
        {
            string bin = dec2Bin(x);
            string binCount = "";
            for (int i = 0; i < bin.Length; i++)
                if (bin[i] == '0')
                    binCount += "1";
                else
                    binCount += '0';
            return bin2Dec(binCount);

        }

        static string dec2Bin(long val)
        {
            return Convert.ToString(val, 2);
        }
        static long bin2Dec(string strBin)
        {
            return Convert.ToInt64(strBin, 2);
        }

        public static void Main1(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                long x = Convert.ToInt64(Console.ReadLine());
                long result = theGreatXor(x);
                Console.WriteLine(result);
            }
        }
    }
}