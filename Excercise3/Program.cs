using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3
{
    internal class Program
    {
        void Matrix()
        {
            int i, j, k = 1;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(k + " ");
                    k++;
                }
                Console.WriteLine();
            }
        }
        void printSumofMatrix()
        {
            int[,] a = new int[3, 3];

            Console.WriteLine("Enter 9 elements:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                int sum = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j] + "\t");
                    sum = sum + a[i, j];
                }

                Console.WriteLine(sum);
                Console.WriteLine();
            }

        }
        void printMatrixZeroArray()
        {
            int[,] a = new int[3, 3];

        Console.WriteLine("Enter 9 elements:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                a[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Output:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int count = 0;

                for (int k = 1; k <= a[i, j]; k++)
                {
                    if (a[i, j] > 1 && a[i, j] % k == 0)
                    {
                        count++;
                    }
                }

                if (a[i, j] == 1 || count == 2)
                    Console.Write(a[i, j] + "\t");
                else
                    Console.Write("0\t");
            }

            Console.WriteLine();
            Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.Matrix();
            //p.printSumofMatrix ();  
            p.printMatrixZeroArray();
        }
    }
}
