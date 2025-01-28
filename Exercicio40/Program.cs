using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double indice1 = 0.4;
                double indice2 = 0.5;
                Console.Clear();
                Console.WriteLine("\nMedição de poluentes\n");

                Console.Write("Informe o indice de poluição:   ");
                string indice = Console.ReadLine();
                if (!double.TryParse(indice, out double IndicePoluicao) || IndicePoluicao < 0)
                {
                    Console.WriteLine("\nIndice de poluição inválido! Informe um valor válido\n");
                    continue;
                }
                if (IndicePoluicao == indice1)
                {
                    Console.WriteLine("Industrias do 1º e 2º  deverão suspender suas atividades");
                   
                }
                else if (IndicePoluicao >=  indice2)
                {
                    Console.WriteLine("Todos os grupos deverão suspender suas atividades");
                
                }
                else
                {
                    Console.WriteLine("Indice adequado!");
                }

            } while (ContinuarOuSair());
        }
        static bool ContinuarOuSair()
        {
            Console.Write("\nDeseja continuar (S) Sim ou (N) Não?  ");
            while (true)
            {
                string resposta = Console.ReadLine().Trim().ToUpper();
            

                if (string.IsNullOrEmpty(resposta) || string.IsNullOrWhiteSpace(resposta) || (resposta != "S" && resposta != "N"))
                    {
                    Console.Write("Erro: Opção inválida! Escolha 'S' ou 'N'  ");
                    continue;

                }
                if (resposta == "N")
                {
                    Console.WriteLine("Oção de sair selecionada...");
                    Console.WriteLine("Pressione qualquer tecla...");
                    Console.ReadKey();
                    return false;
                }
                return true;
            }
        }
    }
}
