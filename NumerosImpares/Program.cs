using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nNumeros Impares\n");

            for (int i = 100; i <= 200; i++) {

                if (i % 2 != 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
            Console.ReadKey();
        }
    }
}
