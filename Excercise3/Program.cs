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
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Matrix();
        }
    }
}
