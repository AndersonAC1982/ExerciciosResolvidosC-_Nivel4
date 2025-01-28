using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\nEscolha uma opção\n");
                Console.WriteLine("1 – Conversão de Graus Celsius em Graus Fahrenheit");
                Console.WriteLine("2 – Conversão de Graus Fahrenheit em Graus Celsius");
                Console.WriteLine("3 – Peso ideal do homem e mulher");
                Console.Write("Opção: ");
                string _opcao = Console.ReadLine();

                if(!int.TryParse(_opcao, out int opcao) || opcao <= 0 && opcao != 1 && opcao != 2 && opcao != 3)
                {
                    Console.WriteLine("Erro: Opção inválida! Selecione uma opção válida");
                    Console.ReadKey();
                    continue;
                }
                switch (opcao)
                { 
                    default:
                        break;

                        case 1:
                            Console.Clear();
                            Console.WriteLine("\nConversor de temperatura\n");
                            Console.Write("Insira a temperatura em Celcius: ");
                            double c = double.Parse(Console.ReadLine());
                            double f = (9 * c + 160) / 5;
                            Console.WriteLine($"A conversão de {c:F2} Celcius para Fahrenheit é {f:F2}");
                            Console.WriteLine("Pressione qualquer tecla...");
                            Console.ReadKey();
                        break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("\nConversor de temperatura\n");
                            Console.Write("Insira a temperatura em Fahrenheit: ");
                            double fah= double.Parse(Console.ReadLine());
                            double cel = (fah - 32) * 5 / 9;
                            Console.WriteLine($"A conversão de {fah:F1} Fahrenheit para Celcius é {cel:F1}");
                            Console.WriteLine("Pressione qualquer tecla...");
                            Console.ReadKey();
                        break ;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("\nCalculo do peso ideal\n");
                            Console.Write("Informe seu sexo (F) feminino ou (M) maculino: ");
                            string sexo = Console.ReadLine().Trim().ToUpper();
                            Console.Write("Informe sua altura no formato 0,00: ");
                            double h = double.Parse(Console.ReadLine());
                            switch (sexo)
                            {
                               default:
                                    Console.WriteLine("Erro: Opção inválida! Ecolha uma opção válida...");
                               break;

                               case "F":
                                    double h_f = (62.1 * h) - 44.7;
                                    Console.WriteLine($"O seu peso idel é {h_f:F2}!");
                               break;

                               case "M":

                                    double h_m = (72.7 * h) - 58;
                                    Console.WriteLine($"O seu peso ideal é {h_m:F2}!");
                               break;
                        }
                        break;


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
                    Console.Write("Erro: Opção inválida! Escolha (S) ou (N): ");
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
