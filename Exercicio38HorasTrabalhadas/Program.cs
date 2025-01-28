using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio38HorasTrabalhadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {

                Console.Clear();
                Console.WriteLine("\nCalculo de horas trabalhados");
                Console.Write("\n Informe o Código:  ");
                string C = Console.ReadLine();
                if (!int.TryParse(C, out int codigo) || codigo < 0)
                {
                    Console.WriteLine("Erro: Código inválido! Digite outro código.");
                    continue;
                }
                Console.Write("\n Informe o Número de horas trabalhadas:  ");
                string N = Console.ReadLine();
                if (!double.TryParse(N, out double NumeroTrab) || NumeroTrab < 0)
                {
                    Console.WriteLine("Erro: Horas informada inválida! Digite novamente");
                    continue;
                }
                double horaext = 0.00;
                double salario = 0.00;

                if (NumeroTrab > 50)
                {
                    salario = NumeroTrab * 10.00;
                    horaext = (NumeroTrab - 50) * 20.00;
                }
                else
                {
                    salario = NumeroTrab * 10.00;
                }

                Console.WriteLine($"O valor de sário total é : {salario:f2}");
                Console.WriteLine($"O valor das horas extra é: {horaext:f2}");

            } while (ContinuarOuSair());
        }
         
        static bool ContinuarOuSair()
        {
                
            Console.Write("Deseja continuar do programa (S) Sim ou (N) Não? ");
            string resposta = Console.ReadLine().Trim().ToUpper();

            while (resposta != "S" && resposta != "N")
            {
                Console.Write("Erro: Opção inválida! Escolha 'S' ou 'N':    ");
                resposta = Console.ReadLine().Trim().ToUpper();
            }

            if (resposta == "N")
            {
                Console.WriteLine("Você escolheu encerrar o programa...");
                Console.WriteLine("Pressione qualquer tecla para finalizar.");
                Console.ReadKey();
                return false;
            }

            return true;
        }
    }
    
}
