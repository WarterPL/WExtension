using System;
using System.Linq;

namespace W
{
    public class W
    {
        public static bool IsEvenNumber(int x) => x % 2 == 0;

        public static double Average(int[] array)
        {
            double avg = array.Sum();
            avg /= array.Length;
            return avg;
        }
        public static double Average(float[] array)
        {
            double avg = array.Sum();
            avg /= array.Length;
            return avg;
        }
        public static double Average(double[] array)
        {
            double avg = array.Sum();
            avg /= array.Length;
            return avg;
        }
    }
}
