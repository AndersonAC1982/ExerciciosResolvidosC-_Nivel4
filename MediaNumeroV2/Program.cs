using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNumeroV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do 
            { 
                // Inicializando a lista para armazenar os 10 números válidos
                List<int> numeros = new List<int>();

                // Garantir que 10 números válidos sejam lidos
                while (numeros.Count < 10)
                {
                    Console.Clear();
                    Console.WriteLine("\nLeitura de Números\n");

                    Console.Write("Insira um número positivo: ");
                    string entrada = Console.ReadLine();

                    // Verifica se a entrada é um número inteiro e positivo
                    if (int.TryParse(entrada, out int numero))
                    {
                        if (numero > 0) // Verifica se o número é positivo
                        {
                            numeros.Add(numero);  // Adiciona o número à lista
                        }
                        else
                        {
                            Console.WriteLine("\nNúmero negativo detectado. Insira apenas números positivos.");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nValor inválido. Por favor, insira um número inteiro.");
                        Console.ReadKey();
                    }
                }

                //gora que 10 números foram lidos, calculamos o maior, menor e a média
                   int maior = numeros.Max();  // Encontra o maior número
                   int menor = numeros.Min();  // Encontra o menor número
                      double media = numeros.Average();  // Calcula a média dos números

                    // Exibindo os resultados
                   Console.WriteLine($"\nO maior número é: {maior}");
                    Console.WriteLine($"O menor número é: {menor}");
                   Console.WriteLine($"A média dos números é: {media:F2}");  // Exibe a média com 2 casas decimais


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
                          Console.WriteLine("\nVocê escolheu continuar...");
                          Console.WriteLine("Digite qualquer tecla para continuar");
                          Console.ReadKey();
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
