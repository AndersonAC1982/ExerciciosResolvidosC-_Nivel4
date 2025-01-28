using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\nPar ou Impar\n");
                Console.Write("infrome um número inteiro: ");
                string num = Console.ReadLine();
                if (!int.TryParse(num, out int numero1))
                {
                    Console.WriteLine("Erro: Valor inválido! Inorme somente números inteiros");
                }
                if (numero1 % 2 == 0)
                {
                    Console.WriteLine($"O número {numero1} é par.");
                }
                else
                {
                    Console.WriteLine($"O número {numero1} é impar.");
                }

                if (numero1 > 0)
                {
                    Console.WriteLine($"O número {numero1} é positivo.");
                }
                else
                {
                    Console.WriteLine($"O número {numero1} é negativo.");
                }

            } while (ContinuarOuSair());
        }

        static bool ContinuarOuSair()
        {
            Console.WriteLine("Deseja continuar no programa (S) Sim ou (N) Não?  ");
            string resposta = Console.ReadLine().Trim().ToUpper();

            while (resposta != "S" && resposta != "N")
            {
                Console.WriteLine("Erro: Opção inválida! Digite 'S' ou 'N'");
                resposta = Console.ReadLine().Trim().ToUpper();
            }

            if (resposta == "N")
            {
                Console.WriteLine("A Opção de sair foi selecionada..");
                Console.WriteLine("Pressione qualquer tecla para finalizar.");
                Console.ReadKey();
                return false;
            }

            return true;
        }
    }
}
