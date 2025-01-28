using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nMédia dos Alunos\n");
                Console.Write("Informe o número da matrícula: ");
                if (!int.TryParse(Console.ReadLine(), out int matricula) || matricula < 0)
                {
                    Console.WriteLine("Erro: Matrícula inválida! Informe uma matrícula com apenas números positivos");
                    ContinuarOuSair();
                    continue;
                }
                Console.Write("\nInforme a nota 1: ");
                double _nota1 = double.Parse(Console.ReadLine());

                Console.Write("\nInforme a nota 2: ");
                double _nota2 = double.Parse(Console.ReadLine());

                Console.Write("\nInforme a nota 3: ");
                double _nota3 = double.Parse(Console.ReadLine());

                Console.Write("\nInforme a nota 4: ");
                double _nota4 = double.Parse(Console.ReadLine());

                double media = (_nota1 + _nota2 + _nota3 + _nota4) / 4;

                Console.WriteLine($"A média do aluno de matrícula {matricula} é {media:F1}");

                if (!ContinuarNoSistema())
                    break;
            }
        }
        static void ContinuarOuSair()
        {
            Console.WriteLine("Digite qualquer tecla para continuar...");
            Console.ReadKey();
        }
        static bool ContinuarNoSistema()
        {
            while (true)
            {           
                Console.Write("\nDeseja continuar o sistema (S) sim ou (N) não? ");
                string resposta = Console.ReadLine().Trim().ToUpper();
                if (resposta == "S")
                    return true;
                if (resposta == "N")
                    return false;
                Console.WriteLine("\nErro: Opção inválida! Digite S ou N");
               
            }
        }
    }
}
