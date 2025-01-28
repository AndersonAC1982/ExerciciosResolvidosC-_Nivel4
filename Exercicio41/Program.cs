using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\nClassificação por idade\n");

                Console.Write("Informe a idade do nadador para saber a classificação:  ");
                string str_idade = Console.ReadLine();
                if (!int.TryParse(str_idade, out int idade) || idade <= 0)
                {
                    Console.WriteLine("Erro: Idade inválida! Informe uma idade acima de 0");
                    continue;
                }
                if (idade >= 5 && idade <= 7)
                {
                    Console.WriteLine("\nInfantil A");
                }
                else if (idade >= 8 && idade <= 11)
                {
                    Console.WriteLine("\nInfantil B");
                }
                else if (idade >= 12 && idade <= 13)
                {
                    Console.WriteLine("\nJuvenil A");
                }
                else if (idade >= 14 && idade <= 17)
                {
                    Console.WriteLine("\nJuvenil B");
                }
                else if (idade >= 18)
                {
                    Console.WriteLine("\nAdultos");
                }
                if (idade >= 1 && idade < 5)
                {
                    Console.WriteLine("\nAtenção! Idade inferior ao mínimo de 5 anos");
                }

            } while (ContinuarOuSair());
        }
        static bool ContinuarOuSair()
        {
            Console.Write("\nDeseja continuar (S)Sim ou (N)Não? ");
            while (true) 
            {
                string resposta = Console.ReadLine().Trim().ToUpper();
                if (string.IsNullOrEmpty(resposta) || string.IsNullOrWhiteSpace(resposta) || (resposta != "S") && (resposta != "N"))
                {
                    Console.WriteLine("Erro: Opção inválida! Escolha (S) ou (N)");
                    continue;
                }
                if (resposta == "N")
                {
                    Console.WriteLine("Saindo do programa...");
                    Console.WriteLine("Pressione qualquer tecla...");
                    Console.ReadKey();
                    return false;
                }
                return true;
            }

        }
    }

}
