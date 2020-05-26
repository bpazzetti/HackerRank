using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation
{
    class OrganizingContainersOfBalls
    {
        static string organizingContainers(int[][] container, int n)
        {
            int[] box = new int[n];
            int[] balls = new int[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    box[i] += container[i][j];
                    balls[i] += container[j][i];
                }
            }

            Array.Sort(box);
            Array.Sort(balls);

            for (int i = 0; i < n; i++)
            {
                if(balls[i] != box[i])
                {
                    return "Impossible";
                }
            }
            return "Possible";
        }

        public static void Main1(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[][] container = new int[n][];

                for (int i = 0; i < n; i++)
                {
                    container[i] = Array.ConvertAll(Console.ReadLine().Split(' '), containerTemp => Convert.ToInt32(containerTemp));
                }

                string result = organizingContainers(container,n);

                Console.WriteLine(result);
            }
        }
    }
}
