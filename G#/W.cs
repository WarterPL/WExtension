using System;
using System.Linq;

namespace W
{
    public static class W
    {
        static Random rnd = new Random();

        public static int Random(int min, int max) => rnd.Next(min, max+1);
        public static int Random(int max) => rnd.Next(0, max+1);
        public static double RandomDouble(int min, int max)
        {
            double val = rnd.NextDouble();
            val = val * (max - min);
            val += min;
            return val;
        }
        public static double RandomDouble(int max)
        {
            double val = rnd.NextDouble();
            val *= max;
            return val;
        }
        
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