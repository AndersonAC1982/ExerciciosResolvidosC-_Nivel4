using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroParEImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int somaPares = 0;
            int somaImpares = 0;

            Console.WriteLine("Digite números positivos (digite um número negativo para encerrar):");

            while (true)
            {
                Console.Write("Digite um número: ");

                if (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                    continue;
                }

                if (numero < 0)
                {
                    break;
                }

                if (numero % 2 == 0)
                {
                    Console.WriteLine($"{numero} é par.");
                    somaPares += numero;
                }
                else
                {
                    Console.WriteLine($"{numero} é ímpar.");
                    somaImpares += numero;
                }
            }

            Console.WriteLine("\nResumo:");
            Console.WriteLine($"Soma dos números pares: {somaPares}");
            Console.WriteLine($"Soma dos números ímpares: {somaImpares}");
            Console.ReadKey();
        }
    }
}
