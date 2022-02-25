using System;

namespace Exercises
{
    class GrayCode
    {
        static int getGray(int n)
        {
            return n^(n>>1);
        }
        static void Main(string[]args)
        {
            int InputNum, GrayNum;
            Console.Write("/n enter the decimal number: ");
            InputNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("/n Binary equivalent of {0}:{1}", InputNum, Convert.ToString(InputNum, 2));
            GrayNum = getGray(InputNum);
            Console.WriteLine("/n Gray code equivalent of {0}:{1}", InputNum, Convert.ToString(GrayNum, 2));
        }
    }
}
