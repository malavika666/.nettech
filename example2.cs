using System;

namespace example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the binary number: ");
            int binaryNumber = int.Parse(Console.ReadLine());
            int decimalValue = 0;
            int base1 = 1;
            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            Console.Write($"decimal value:{decimalValue}");

            Console.ReadKey();
        }
    }
}
