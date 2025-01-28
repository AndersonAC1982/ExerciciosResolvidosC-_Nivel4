using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Exercicio43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger totalGrains = 0;
            BigInteger grainsInSquare = 1;

            // O tabuleiro de xadrez tem 64 casas
            for (int i = 1; i <= 64; i++)
            {
                totalGrains += grainsInSquare;
                grainsInSquare *= 2;  // O número de grãos dobra a cada casa
            }

            // Exibe o número total de grãos
            Console.WriteLine("O total de grãos de trigo que o monge espera receber é: " + totalGrains);
            Console.ReadKey();
        }
    }
    
}
