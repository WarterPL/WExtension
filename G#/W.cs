using System;
using System.Linq;

namespace W
{
    public class W
    {
        public static bool IsEvenNumber(int x) => x % 2 == 0;

        public static double Average(params int[] array)
        {
            double avg = array.Sum();
            avg /= array.Length;
            return avg;
        }
        public static double Average(params float[] array)
        {
            double avg = array.Sum();
            avg /= array.Length;
            return avg;
        }
        public static double Average(params double[] array)
        {
            double avg = array.Sum();
            avg /= array.Length;
            return avg;
        }
    }
}
