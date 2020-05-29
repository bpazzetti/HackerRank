using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h30DaysOfCode
{
    class Day14_Scope
    {
        class Difference
        {
            private int[] elements;
            public int maximumDifference;

            // Add your code here
            public Difference(int[] elements)
            {
                this.elements = elements;
            }

            public void computeDifference()
            {
                int min = elements.Min();
                int max = elements.Max();
                maximumDifference = Math.Abs(max - min);
            }

        }

        public static void Main1(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}
