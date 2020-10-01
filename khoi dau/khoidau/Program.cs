/*
using System;

namespace khoidau
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
*/

using System;

namespace HelloApp
{ 
    class Program
    {
        static void Main(string [] args)
        {
            int m, n;
            Console.Write("Number of rows : ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of columns : ");
            n = Convert.ToInt32(Console.ReadLine());
            int[][] Matrix = new int[m][];
            for (int i = 0; i < m; i++)
            {
                Matrix[i] = new int[n];
            }

            for (int i=0; i < m; i++)
            {
                for (int j=0; j < n; j++)
                {
                    int element;
                    Console.Write("Matrix[{0},{1}] : ", i, j);
                    element = Convert.ToInt32(Console.ReadLine());
                    Matrix[i][j] = element;

                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} \t ",Matrix[i][j]);

                }
                Console.Write("\n");
            }


        }
    }
}