using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Implementation
{
    static class CutTheSticks
    {
        static int[] cutTheSticks(int[] arr)
        {
            List<int> res = new List<int>();
            List<int> list = new List<int>(arr);
            int min = 0;

            do
            {
                res.Add(list.Count());
                min = list.Count > 0 ? list.Min() : 0;

                int i = 0;
                while (i < list.Count)
                {
                    list[i] -= min;
                    if (list[i] == 0)
                    {
                        list.RemoveAt(i);
                    }
                    else
                    {
                        i++;
                    }
                }                
            } while (list.Count > 0);
            
            return res.ToArray();
        }

        public static void Main1(string[] args)
        {            
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int[] result = cutTheSticks(arr);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}
