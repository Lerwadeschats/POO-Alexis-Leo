using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_GC_A2_Partiel_POO.Level_1
{
    public class MyMath
    {
        // Interdictions :
        // classe Math & MathF
        public static int Abs(int input)
        {
            return Math.Abs(input); 
            throw new NotImplementedException();
        }

        // Interdictions :
        // classe Math & MathF
        public static int Clamp(int input, int min, int max)
        {
            if (input < min)
            {
                return min;
            }
            else if (input > max)
            {
                return max;
            }
            else
            {
                return input;
            }
            throw new NotImplementedException();
        }

        // Interdictions :
        // classe Math & MathF
        public static int Floor(float input)
        {
            int result = (int) input;
            return result;
            throw new NotImplementedException();
        }

        // Interdictions :
        // classe Math & MathF
        public static int Ceil(float input)
        {
            if (input%1== 0)
            {
                return (int) input;
            }
            else
            {
                return (int) input + 1;
            }
            throw new NotImplementedException();
        }

        // Interdictions :
        // classe Math & MathF
        public static int Round(float input)
        {
            if (input - (int)input >= 0.50)
            {
                return (int) input + 1 ;
            }
            else
            {
                return (int) input;
            }
            throw new NotImplementedException();
        }

        // Interdictions :
        // classe Math & MathF
        // LINQ & Enumerable
        public static float CalculateAverage(int[] input)
        {

            throw new NotImplementedException();
        }

    }
}
