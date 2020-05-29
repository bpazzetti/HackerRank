using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h30DaysOfCode
{
    class Day26_NestedLogic
    {
        public static void Main1(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string[] d1M1Y1 = Console.ReadLine().Split(' ');

            int d1 = Convert.ToInt32(d1M1Y1[0]);

            int m1 = Convert.ToInt32(d1M1Y1[1]);

            int y1 = Convert.ToInt32(d1M1Y1[2]);

            string[] d2M2Y2 = Console.ReadLine().Split(' ');

            int d2 = Convert.ToInt32(d2M2Y2[0]);

            int m2 = Convert.ToInt32(d2M2Y2[1]);

            int y2 = Convert.ToInt32(d2M2Y2[2]);

            DateTime expected = new DateTime(y2, m2, d2);
            DateTime returned = new DateTime(y1, m1, d1);

            if (returned <= expected)
                Console.WriteLine($"{0}");
            else if(returned > expected && m1 == m2 && y1 == y2)
                Console.WriteLine($"{15 * int.Parse((returned - expected).TotalDays.ToString())}");
            else if (returned > expected && y1 == y2)
                Console.WriteLine($"{500 * (((returned.Year - expected.Year) * 12) + returned.Month - expected.Month)}");
            else if (returned > expected && y1 != y2)
                Console.WriteLine($"{10000}");                        
        }
    }
}
