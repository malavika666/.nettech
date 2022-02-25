using System;

namespace ConsoleApp17
{
    class SumofDiagonals
    {

        static void Main(string[] args)
        {
            int MaxRow, MaxCol, SUM = 0;
            int[,] Matrix;
            Console.WriteLine("\n --------SUM OF DIAGONAL OF A MATRIX--------");
            Console.WriteLine(" ENTER THE NUMBERS OF ROWS : ");
            MaxRow = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n enter the number of columns: ");
            MaxCol = Convert.ToInt32(Console.ReadLine());
            if (MaxRow != MaxCol)
            {
                Console.WriteLine("\n the dimensions entered are not of square Matrix");
                Console.WriteLine("\n exiting the program");
                return;
            }
            Matrix = new int[MaxRow, MaxCol];

            for (int i = 0; i < MaxRow; i++)
            {
                for (int j = 0; j < MaxCol; j++)
                {
                    Console.Write("\n enter the {0},{1}th element of the matrix:", (i + 1), (j + 1));
                    Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n the entered Matrix is: ");
            for (int i = 0; i < MaxRow; i++)
            {
                for (int j = 0; j < MaxCol; j++)
                {
                    Console.Write("   " + Matrix[i, j]);
                    if (i == j)
                    {
                        SUM += Matrix[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n the sum of diagonal is" + SUM);
        }
    }
}
