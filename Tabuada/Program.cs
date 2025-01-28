using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n TABUADA\n");

                Console.Write("Informe o número que quer visualizar a tabuada: ");
                if (!int.TryParse(Console.ReadLine(), out int numero) || numero <= 0)
                {
                    Console.WriteLine("Erro: número inválido! Informe um número inteiro e positivo...");
                    ContinuarOuSair();
                    continue;
                    
                }

                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    Console.WriteLine($"{numero} X {i} = {resultado}");
                }

                if (!ContinuarNoSistema())
                    break;
            }
        }
        static bool ContinuarNoSistema()
        {
            Console.Write("\nDeseja continuar o sistema (S) sim ou (N) não: ");
            while (true)
            {

                string resposta = Console.ReadLine().Trim().ToUpper();
                if (resposta == "S")
                    return true;
                if (resposta == "N")
                    return false;
                Console.WriteLine("Erro: Opção inválida! Digite S ou N");
            }

        }
        static void ContinuarOuSair()
        {
            Console.WriteLine("Pressiaone qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}