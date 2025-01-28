using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContagemDe1a100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nContagen de 1 a 100\n");
            for (int i = 1; i <= 100; i++)
            {

                if (i % 10 == 0)
                {
                    Console.WriteLine($"\n{i} Multiplo de 10\n");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();

        }
    }
}
