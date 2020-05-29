using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace h30DaysOfCode
{
    class Day27_Testing
    {
        public static int minimum_index(int[] seq)
        {
            if (seq.Length == 0)
            {
                throw new ArgumentException("Cannot get the minimum value index from an empty sequence");
            }
            int min_idx = 0;
            for (int i = 1; i < seq.Length; ++i)
            {
                if (seq[i] < seq[min_idx])
                {
                    min_idx = i;
                }
            }
            return min_idx;
        }

        static class TestDataEmptyArray
        {
            public static int[] get_array()
            {
                // complete this function
                return Array.Empty<int>();
            }
        }

        static class TestDataUniqueValues
        {
            public static int[] get_array()
            {
                // complete this function
                int[] arr = new int[2];
                arr[0] = 1;
                arr[1] = 2;
                return arr;
            }

            public static int get_expected_result()
            {
                // complete this function
                return 0;
            }
        }

        static class TestDataExactlyTwoDifferentMinimums
        {
            public static int[] get_array()
            {
                // complete this function
                int[] arr = new int[2];
                arr[0] = 1;
                arr[1] = 1;
                return arr;
            }

            public static int get_expected_result()
            {
                // complete this function
                return 0;
            }
        }

        public static void TestWithEmptyArray()
        {
            try
            {
                int[] seq = TestDataEmptyArray.get_array();
                int result = minimum_index(seq);
            }
            catch (ArgumentException)
            {
                return;
            }
            throw new AssertionError("Exception wasn't thrown as expected");
        }

        public static void TestWithUniqueValues()
        {
            int[] seq = TestDataUniqueValues.get_array();
            if (seq.Length < 2)
            {
                throw new AssertionError("less than 2 elements in the array");
            }

            int[] tmp = new int[seq.Length];
            for (int i = 0; i < seq.Length; ++i)
            {
                tmp[i] = seq[i];
            }
            if (!((new HashSet<int>(tmp).Count == seq.Length)))
            {
                throw new AssertionError("not all values are unique");
            }

            int expected_result = TestDataUniqueValues.get_expected_result();
            int result = minimum_index(seq);
            if (result != expected_result)
            {
                throw new AssertionError("result is different than the expected result");
            }
        }

        public static void TestWithExactlyTwoDifferentMinimums()
        {
            int[] seq = TestDataExactlyTwoDifferentMinimums.get_array();
            if (seq.Length < 2)
            {
                throw new AssertionError("less than 2 elements in the array");
            }

            int[] tmp = (int[])seq.Clone();

            Array.Sort(tmp);            
            if (!(tmp[0] == tmp[1] && (tmp.Length == 2 || tmp[1] < tmp[2])))
            {
                throw new AssertionError("there are not exactly two minimums in the array");
            }

            int expected_result = TestDataExactlyTwoDifferentMinimums.get_expected_result();
            int result = minimum_index(seq);
            if (result != expected_result)
            {
                throw new AssertionError("result is different than the expected result");
            }
        }

        public static void Main1(String[] args)
        {
            TestWithEmptyArray();
            TestWithUniqueValues();
            TestWithExactlyTwoDifferentMinimums();
            Console.WriteLine("OK");
        }
    }

    [Serializable]
    internal class AssertionError : Exception
    {
        public AssertionError()
        {
        }

        public AssertionError(string message) : base(message)
        {
        }

        public AssertionError(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AssertionError(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
