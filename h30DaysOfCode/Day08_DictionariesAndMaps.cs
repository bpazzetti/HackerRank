using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h30DaysOfCode
{
    class Day08_DictionariesAndMaps
    {
        public static void Main1(String[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                if (!phonebook.ContainsKey(tokens[0]))
                    phonebook.Add(tokens[0], tokens[1]);
            }
            string q = Console.ReadLine();
            while (!String.IsNullOrEmpty(q))
            {
                if (phonebook.ContainsKey(q))
                    Console.WriteLine("{0}={1}", q, phonebook[q]);
                else
                    Console.WriteLine("Not found");
                q = Console.ReadLine();
            }

        }
    }
}
