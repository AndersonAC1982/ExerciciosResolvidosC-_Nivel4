using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxEMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) // Laço para repetir o programa enquanto o usuário desejar
            {
                Console.Clear(); // Limpa o console para uma nova execução

                Console.WriteLine("\nMenor e Maior número\n");

                // Solicita que o usuário informe os números
                Console.Write("Informe um conjunto de números separados por 'espaço': ");
                string entrada = Console.ReadLine(); // Lê a entrada como texto

                // ===== Parte Original (com erro) =====
                // Esta linha tenta converter diretamente os valores da entrada para números
                // e armazená-los em um array de inteiros, mas usa Select(int.TryParse) de forma errada.
                /*
                int[] numeros = entrada.Split(' ').Select(int.TryParse).ToArray();
                if (numeros.Length > 0) // Verifica se há números para processar
                {
                    break; // Sai do laço (isso está fora do lugar neste caso)
                }
                int maior = numeros.Max(); // Obtém o maior número
                int menor = numeros.Min(); // Obtém o menor número
                */

                // ===== Parte Corrigida =====
                // Dividimos a entrada, validamos cada valor e convertemos os válidos para uma lista
                // Dividimos a entrada, validamos cada valor e convertemos os válidos para uma lista
                List<int> numeros = new List<int>(); // Cria uma lista para armazenar números válidos
                foreach (var item in entrada.Split(' ')) // Divide a entrada com base no espaço
                {
                    if (int.TryParse(item, out int numero)) // Verifica se o valor pode ser convertido para int
                    {
                        if (numero < 0) // Se o número for negativo, encerra o programa
                        {
                            Console.WriteLine("\nNúmero negativo detectado. Programa encerrado.");
                            return; // Sai do programa completamente
                        }
                        numeros.Add(numero); // Adiciona o número válido à lista
                    }
                    else
                    {
                        Console.WriteLine($"Valor inválido ignorado: {item}"); // Feedback para valores inválidos
                    }
                }

                if (numeros.Count > 0) // Verifica se há números válidos na lista
                {
                    int maior = numeros.Max(); // Calcula o maior número
                    int menor = numeros.Min(); // Calcula o menor número

                    Console.WriteLine($"\nO menor número é: {menor}"); // Exibe o menor número
                    Console.WriteLine($"O maior número é: {maior}"); // Exibe o maior número
                }
                else
                {
                    Console.WriteLine("\nNenhum número válido foi informado."); // Mensagem para lista vazia
                }

                // Pergunta ao usuário se ele quer continuar ou sair
                if (!ContinuarOuSair())
                    break; // Sai do laço principal e encerra o programa
            }
        }

        // Método para verificar se o usuário deseja continuar
        static bool ContinuarOuSair()
        {
            Console.Write("\nDeseja continuar? (S) Sim ou (N) Não:");
            while (true) // Laço para garantir uma resposta válida
            {
                string resposta = Console.ReadLine().Trim().ToUpper(); // Lê e normaliza a resposta

                if (resposta == "S") // Se o usuário digitar "S", continua
                    return true;
                if (resposta == "N") // Se o usuário digitar "N", encerra
                    return false;

                Console.WriteLine("Erro: Opção inválida! Digite 'S' ou 'N'."); // Feedback para entrada inválida
            }
        }
    }
}

