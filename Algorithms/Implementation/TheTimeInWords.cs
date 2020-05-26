using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Implementation
{
    class TheTimeInWords
    {
        static string timeInWords(int h, int m)
        {
            string result = string.Empty;
            if (m == 0)
                return ConvertToWord(h.ToString()) + " o' clock";
            if (m == 1)
                return ConvertToWord(m.ToString()) + " minute past " + ConvertToWord(h.ToString());
            if (m < 30 && m != 15)
                return ConvertToWord(m.ToString()) + " minutes past " + ConvertToWord(h.ToString());
            if(m == 15)
                return "quarter past " + ConvertToWord(h.ToString());
            if (m == 30)
                return "half past " + ConvertToWord(h.ToString());
            if (m > 30)
            {
                m = 60 - m;
                h = h + 1 > 12 ? 1 : h + 1;
                if (m == 1)
                    return ConvertToWord(m.ToString()) + " minute to " + ConvertToWord(h.ToString());
                if (m < 30 && m != 15)
                    return ConvertToWord(m.ToString()) + " minutes to " + ConvertToWord(h.ToString());
                if (m == 15)
                    return "quarter to " + ConvertToWord(h.ToString());
            }                
            return result.ToLower();
        }

        static string ConvertToWord(string number)
        {
            if (number.Length == 1)
                return ones(number).ToLower();
            else
                return tens(number).ToLower();
        }

        private static String ones(String Number)
        {
            int _Number = Convert.ToInt32(Number);
            String name = "";
            switch (_Number)
            {
                case 1:
                    name = "One";
                    break;
                case 2:
                    name = "Two";
                    break;
                case 3:
                    name = "Three";
                    break;
                case 4:
                    name = "Four";
                    break;
                case 5:
                    name = "Five";
                    break;
                case 6:
                    name = "Six";
                    break;
                case 7:
                    name = "Seven";
                    break;
                case 8:
                    name = "Eight";
                    break;
                case 9:
                    name = "Nine";
                    break;
            }
            return name;
        }

        private static String tens(String Number)
        {
            int _Number = Convert.ToInt32(Number);
            String name = null;
            switch (_Number)
            {
                case 10:
                    name = "Ten";
                    break;
                case 11:
                    name = "Eleven";
                    break;
                case 12:
                    name = "Twelve";
                    break;
                case 13:
                    name = "Thirteen";
                    break;
                case 14:
                    name = "Fourteen";
                    break;
                case 15:
                    name = "Fifteen";
                    break;
                case 16:
                    name = "Sixteen";
                    break;
                case 17:
                    name = "Seventeen";
                    break;
                case 18:
                    name = "Eighteen";
                    break;
                case 19:
                    name = "Nineteen";
                    break;
                case 20:
                    name = "Twenty";
                    break;
                case 30:
                    name = "Thirty";
                    break;
                default:
                    if (_Number > 0)
                    {
                        name = tens(Number.Substring(0, 1) + "0") + " " + ones(Number.Substring(1));
                    }
                    break;
            }
            return name;
        }
        public static void Main1(string[] args)
        {
            int h = Convert.ToInt32(Console.ReadLine());

            int m = Convert.ToInt32(Console.ReadLine());

            string result = timeInWords(h, m);

            Console.WriteLine(result);
        }
    }
}
