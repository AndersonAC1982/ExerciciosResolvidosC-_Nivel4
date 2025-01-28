using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraBaseNumerica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\nCalculadora de Base Numérica\n");

                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.Write("Inorme a opção: ");
                string escolha = Console.ReadLine().Trim();
                if (!int.TryParse(escolha, out int opcao) || opcao < 1 || opcao > 4 )
                {
                    Console.WriteLine("Erro: Opção inválida! Digite um número entre 1 e 4.");
                    Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("\nInforme o primeiro número: ");
                string numero1 = Console.ReadLine().Trim();
                if (!int.TryParse(numero1, out int num1) || num1 < 0 )
                {
                    Console.WriteLine("Erro.: valor invalido! Digite somente números validos e positivos...");
                        continue;
                }
                Console.Write("\nInforme o segundo número: ");
                string numero2 = Console.ReadLine().Trim();
                if (!int.TryParse(numero2, out int num2) || num2 < 0)
                {
                    Console.WriteLine("Erro.: valor invalido! Digite somente números validos e positivos...");
                        continue;
                }
                int resultado = 0;

                switch (opcao)
                {
                    default:
                        Console.WriteLine("Erro: Opção inválida!");
                        return;
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine($"A  adição de {num1} e {num2} é = {resultado}");
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine($"A subtração de {numero1} e {numero2} é = {resultado}");
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine($"A  adição de {numero1} e {numero2} é = {resultado}");
                        break;
                    case 4:
                        resultado = num1 / num2;
                        Console.WriteLine($"A  adição de {numero1} e {numero2} é = {resultado}");
                        break;
                }
            } while (ContinuarOuSair());
        }

        static bool ContinuarOuSair()
        {
            Console.Write("\nDeseja continuar (S) Sim ou (N) Não?  ");

            while (true)
            {
                string resposta = Console.ReadLine().Trim().ToUpper();

                if (resposta == "S")
                {
                    return true;
                }
                else if (resposta == "N")
                {
                    Console.WriteLine("\nVocê escolheu encerrar...");
                    Console.WriteLine("Digite qualquer tecla para continuar");
                    Console.ReadKey();
                    return false;
                }
                else
                {
                    Console.WriteLine("\nErro: opção inválida! Digita 'S' ou 'N'");
                    Console.ReadKey();
                }

            }
        }

    }
    
}
