using System;
using System.Collections.Generic;
using System.Linq;

namespace MediaNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nMedia numero\n");

                Console.Write("Insira 10 numeros positivos separado por espaço: ");

                string entrada = Console.ReadLine();

                //Dividir a entrada e validar os valores e converter os válidos para a lista
                List<int> numeros = new List<int>();
                foreach (var item in entrada.Split(' '))
                {
                    if (int.TryParse(item, out int numero))

                    {
                        if (numero < 0)
                        {
                            Console.WriteLine("\nNumero negativo detectado. Encerrando programa...\n");
                            return;
                        }
                        numeros.Add(numero);
                    }
                    else
                    {
                        Console.WriteLine($"Valor invalido ignorado: {item}");
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
                    Console.WriteLine("\nNenhum número foi informado");
                }
                if (!ContinuarOuSair())
                    break;
            }
        }



        static bool ContinuarOuSair()
        {
            Console.Write("\nDeseja continuar? (S) Sim ou (N) Não:");
            while (true) // Laço para garantir uma resposta válida
            {
                string resposta = Console.ReadLine().Trim().ToUpper(); // Lê e normaliza a resposta

                if (resposta == "S") // Se o usuário digitar "S", continua
                {
                    Console.WriteLine("Você escolheu continuar.");
                    Console.WriteLine("Aperte qualquer tecla...");
                    Console.ReadKey();
                    return true;
                }
                if (resposta == "N") // Se o usuário digitar "N", encerra
                {
                    Console.WriteLine("Você escolheu encerrar.");
                    Console.WriteLine("Aperte qualquer tecla...");
                    Console.ReadKey();
                    return false;
                }

                Console.WriteLine("Erro: Opção inválida! Digite 'S' ou 'N'."); // Feedback para entrada inválida
                Console.ReadKey();
            }
        }
    }
}


