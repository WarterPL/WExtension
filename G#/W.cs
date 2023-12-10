using System;
using System.Linq;

namespace W
{
    public static class W
    {
        public static bool IsEvenNumber(int x) => x % 2 == 0;

        public static double Average(params int[] array)
        {
            double avg = 0;
            foreach (var n in array)
                avg += n;

            avg /= array.Length;
            return avg;
        }
        public static double Average(params float[] array)
        {
            double avg = 0;
            foreach (var n in array)
                avg += n;

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
    public class WRandom : Random
    {
        public int Random(int min, int max) { return base.Next(min, max + 1); }
        public int Random(int max) => Random(0, max);

        public double RandomDouble(int min, int max)
        {
            double val = base.NextDouble();
            val = val * (max - min);
            val += min;
            return val;
        }
        public double RandomDouble(int max) => RandomDouble(0, max);
    }
}