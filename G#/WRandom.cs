using System;

namespace W
{
    [Serializable]
    public class WRandom
    {
        Random rnd = new Random();

        public int Next(int min, int max) => rnd.Next(min, max + 1);
        public int Next(int max) => rnd.Next(0, max + 1);
        public double NextDouble(int min, int max)
        {
            double val = rnd.NextDouble();
            val = val * (max - min);
            val += min;
            return val;
        }
        public double NextDouble(int max)
        {
            double val = rnd.NextDouble();
            val *= max;
            return val;
        }
        public double NextDouble()
        {
            double val = rnd.NextDouble();
            return val;
        }
    }
}