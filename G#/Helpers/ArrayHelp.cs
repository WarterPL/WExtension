using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WClasses.Helpers
{
    public static class ArrayHelp
    {
        public static T[] Extract<T>(this T[,] array, int index)
        {
            int _1stDimLength = array.GetLength(1);
            T[] output = new T[_1stDimLength];

            for (int i = 0; i < _1stDimLength; i++)
            {
                output[i] = array[index, i];
            }

            return output;
        }
        public static T[,] Extract<T>(this T[,,] array, int index)
        {
            int _1stDimLength = array.GetLength(1);
            int _2ndDimLength = array.GetLength(2);
            T[,] output = new T[_1stDimLength, _2ndDimLength];

            for (int i = 0; i < _1stDimLength; i++)
            {
                for (int j = 0; j < _2ndDimLength; j++)
                {
                    output[i, j] = array[index, i, j];
                }
            }
            return output;
        }
        public static T[,,] Extract<T>(this T[,,,] array, int index)
        {
            int _1stDimLength = array.GetLength(1);
            int _2ndDimLength = array.GetLength(2);
            int _3ndDimLength = array.GetLength(3);
            T[,,] output = new T[_1stDimLength, _2ndDimLength, _3ndDimLength];

            for (int i = 0; i < _1stDimLength; i++)
            {
                for (int j = 0; j < _2ndDimLength; j++)
                {
                    for(int k = 0; k < _3ndDimLength; k++)
                    {
                        output[i, j, k] = array[index, i, j, k];
                    }
                }
            }
            return output;
        }
    }
}
