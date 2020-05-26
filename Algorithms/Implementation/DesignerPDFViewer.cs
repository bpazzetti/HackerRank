using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Algorithms.Implementation
{
    class DesignerPDFViewer
    {

        static void Main1(String[] args)
        {
            string[] h_temp = Console.ReadLine().Split(' ');
            int[] h = Array.ConvertAll(h_temp, Int32.Parse);
            string word = Console.ReadLine();
            //var arrFirst = new int[26];
            int height = 1;
            for (int i = 0; i < word.Length; i++)
                if (h[word[i] - 'a'] > height)
                    height = h[word[i] - 'a'];
            Console.WriteLine(height * word.Length);

        }
    }
}