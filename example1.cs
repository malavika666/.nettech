using System;

namespace DTOB
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the decimal number: ");
            int number = int.Parse(Console.ReadLine());
            int i;
            int[] numberArray = new int[10];
            for(i=0;number>0;i++)
            {
                numberArray[i] = number % 2;
                number = number / 2;
            }
            Console.Write("binary representation of the given no: ");
            for(i=i-1;i>=0;i--)
            {
                Console.Write(numberArray[i]);
            }
            Console.ReadLine();
        }
    }
}
