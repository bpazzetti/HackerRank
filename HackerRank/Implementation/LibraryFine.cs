using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Implementation
{
    static class LibraryFine
    {
        static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            DateTime expected = new DateTime(y2, m2, d2);
            DateTime returned = new DateTime(y1, m1, d1);

            if (returned <= expected)
                return 0;

            if (returned > expected && m1 == m2 && y1 == y2)
                return 15 * int.Parse((returned - expected).TotalDays.ToString());

            if (returned > expected && y1 == y2)
                return 500 * (((returned.Year - expected.Year) * 12) + returned.Month - expected.Month);

            if (returned > expected && y1 != y2)
                return 10000;

            return 0;
        }

        public static void Main1(string[] args)
        {            
            string[] d1M1Y1 = Console.ReadLine().Split(' ');

            int d1 = Convert.ToInt32(d1M1Y1[0]);

            int m1 = Convert.ToInt32(d1M1Y1[1]);

            int y1 = Convert.ToInt32(d1M1Y1[2]);

            string[] d2M2Y2 = Console.ReadLine().Split(' ');

            int d2 = Convert.ToInt32(d2M2Y2[0]);

            int m2 = Convert.ToInt32(d2M2Y2[1]);

            int y2 = Convert.ToInt32(d2M2Y2[2]);

            int result = libraryFine(d1, m1, y1, d2, m2, y2);

            Console.WriteLine(result);
        }
    }
}
