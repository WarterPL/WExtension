using System.Linq;
using System.Runtime.InteropServices;

namespace W
{
    public static class W
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
            double avg = 0;
            foreach (var n in array)
                avg += n;

            avg /= array.Length;
            return avg;
        }
    }
}