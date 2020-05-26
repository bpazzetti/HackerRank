using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation
{
    class BiggerIsGreater
    {
        // Complete the biggerIsGreater function below.
        static string biggerIsGreater(string w)
        {
            string result = "no answer";
            char[] array = w.ToArray();
            nextPermutation(array);            
            result = string.Join("", array);            
            if (result == w)
                return "no answer";
            else
                return result;
        }

        static bool nextPermutation(char[] array)
        {
            int i = array.Length - 1;
            // Find longest non-increasing suffix
            while (i > 0 && array[i - 1] >= array[i])
                i--;

            // Are we at the last permutation already?
            if (i <= 0)
                return false;

            // Let array[i - 1] be the pivot
            // Find rightmost element that exceeds the pivot
            int j = array.Length - 1;
            while (array[j] <= array[i - 1])
                j--;
            // Now the value array[j] will become the new pivot
            // Assertion: j >= i

            // Swap the pivot with j
            char temp = array[i - 1];
            array[i - 1] = array[j];
            array[j] = temp;

            // Reverse the suffix
            j = array.Length - 1;
            while (i < j)
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }

            // Successfully computed the next permutation
            return true;

        }

        public static void Main1(string[] args)
        {            
            int T = Convert.ToInt32(Console.ReadLine());

            for (int TItr = 0; TItr < T; TItr++)
            {
                string w = Console.ReadLine();

                string result = biggerIsGreater(w);

                Console.WriteLine(result);
            }
        }
    }
}
