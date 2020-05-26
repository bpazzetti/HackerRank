using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h30DaysOfCode
{
    class Day02_Operators
    {
        public static void Main1(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            double mealCost = 0.00;
            double dtip = 0;
            double dtax = 0;
            int tip = 0;
            int tax = 0;

            mealCost = Convert.ToDouble(Console.ReadLine());
            tip = Convert.ToInt32(Console.ReadLine());
            tax = Convert.ToInt32(Console.ReadLine());

            dtip = (mealCost * tip) / 100;
            dtax = (mealCost * tax) / 100;

            double totalCost = mealCost + dtip + dtax;

            Console.WriteLine("The total meal cost is {0} dollars.", Math.Round(totalCost, 0));
        }
    }
}
