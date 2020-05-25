using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace HackerRank.Warmup
{
    class N10_TimeConversion
    {

        static string timeConversion(string s)
        {
            // Complete this function
            string[] hour = s.Split(':');
            if (hour[2].IndexOf("AM") > 0)
            {
                if (hour[0] == "12")
                    hour[0] = "00";
            }
            else
            {
                if (hour[0] != "12")
                {
                    int h = Convert.ToInt32(hour[0]) + 12;
                    hour[0] = h.ToString("00");
                }
            }
            string result = hour[0] + ":" + hour[1] + ":" + hour[2].Substring(0, 2);
            return result;
        }

        static void Main1(String[] args)
        {
            string s = Console.ReadLine();
            string result = timeConversion(s);
            Console.WriteLine(result);
        }
    }
}