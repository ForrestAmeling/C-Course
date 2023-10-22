using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static int AbsoluteOfSum(int a, int b)
        {
            return Math.Abs(a + b);
        }
    }
}


//Other way to soleve this exercise

using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static int AbsoluteOfSum(int a, int b)
        {
            var sum = a + b;
            if(sum>=0)
            {
                return sum;
            }
            return -sum;
        }
    }
}
