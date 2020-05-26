using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation
{
    class Encryption
    {
        static string encryption(string s)
        {
            s = s.Replace(" ", "");
            string result = string.Empty;

            int y = Convert.ToInt32(Math.Floor(Math.Sqrt(s.Length)));
            int x = Convert.ToInt32(Math.Ceiling(Math.Sqrt(s.Length)));

            if (y * x < s.Length)
            {
                y++;
            }

            char[][] matrix = new char[y][];
            for (int i = 0; i < y; i++)
            {
                matrix[i] = new char[x];
            }
                        
            int k = 0;

            for (int j = 0; j < y; j++)
            {
                for (int i = 0; i < x; i++)
                {
                    if (k >= s.Length)
                        break;
                    matrix[j][i] = s[k];                    
                    k++;                    
                }
            }

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {                    
                    if(matrix[j][i] > 0)
                        result += matrix[j][i];                     
                }

                result += " ";
            }
            return result.Trim();
        }

        public static void Main1(string[] args)
        {
            string s = Console.ReadLine();

            string result = encryption(s);

            Console.WriteLine(result);
        }
    }
}
