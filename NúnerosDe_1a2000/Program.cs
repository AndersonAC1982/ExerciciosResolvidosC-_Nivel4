using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NúnerosDe_1a2000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nExibir números de 1 a 2000\n");

            for (int i = 1; i <= 2000; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
