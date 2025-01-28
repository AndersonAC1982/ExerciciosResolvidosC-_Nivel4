using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNumerosV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nMédia de números\n");

                Console.Write("Insira números positivos separados por espaço: ");
                string entrada = Console.ReadLine();

                // Dividir a entrada e validar os valores e converter os válidos para a lista
                List<int> numeros = new List<int>();
                foreach (var item in entrada.Split(' '))
                {
                    if (int.TryParse(item, out int numero))
                    {
                        if (numero < 0)
                        {
                            Console.WriteLine("\nNúmero negativo detectado. Encerrando programa...\n");
                            return;
                        }
                        numeros.Add(numero);
                    }
                    else
                    {
                        Console.WriteLine($"Valor inválido ignorado: {item}");
                    }
                }

                if (numeros.Count > 0)
                {
                    int maior = numeros.Max();
                    int menor = numeros.Min();
                    double media = numeros.Average();

                    Console.WriteLine($"O maior número é {maior}");
                    Console.WriteLine($"O menor número é {menor}");
                    Console.WriteLine($"A média dos números é: {media:F2}");
                }
                else
                {
                    Console.WriteLine("\nNenhum número válido foi informado.");
                }

                if (!ContinuarOuSair()) // Verifica se o usuário quer continuar
                {
                    Console.WriteLine("Encerrando o programa a pedido do usuário...");
                    break;
                }
            }

            Console.WriteLine("Programa finalizado. Obrigado!");
        }

        static bool ContinuarOuSair()
        {
            Console.Write("\nDeseja continuar? (S) Sim ou (N) Não: ");
            while (true)
            {
                string resposta = Console.ReadLine().Trim().ToUpper();

                if (resposta == "S") // Continua
                {
                    Console.WriteLine("Você escolheu continuar.");
                    Console.WriteLine("Aperte qualquer tecla...");
                    Console.ReadKey();
                    return true;
                }
                if (resposta == "N") // Sai
                {
                    Console.WriteLine("Você escolheu encerrar.");
                    Console.WriteLine("Aperte qualquer tecla...");
                    Console.ReadKey();
                    return false;
                }

                Console.WriteLine("Erro: Opção inválida! Digite 'S' ou 'N'.");
            }
        }
    }

          
}

