using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h30DaysOfCode
{
    class Day01_DataTypes
    {
        public static void Main1(String[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            // Declare second integer, double, and String variables.
            int iv;
            double dv;
            string ss;
            // Read and save an integer, double, and String to your variables.
            iv = Convert.ToInt32(Console.ReadLine());
            dv = Convert.ToDouble(Console.ReadLine());
            ss = Console.ReadLine();
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + iv);
            // Print the sum of the double variables on a new line.
            Console.WriteLine("{0:F1}", d + dv);
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + ss);
        }
    }
}
