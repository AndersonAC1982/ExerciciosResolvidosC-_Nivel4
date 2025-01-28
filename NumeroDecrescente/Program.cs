using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroDecrescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine("I =" + i);
            }
            Console.ReadKey();
        }
    }
}
