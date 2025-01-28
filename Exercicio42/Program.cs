using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio42
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
                Console.Write("Informe um conjunto de números separados por 'espaço' ou 0 para encerrar: ");
                string entrada = Console.ReadLine(); // Lê a entrada como texto


                List<int> numeros = new List<int>(); // Cria uma lista para armazenar números válidos
                foreach (var item in entrada.Split(' ')) // Divide a entrada com base no espaço
                {
                    if (int.TryParse(item, out int numero)) // Verifica se o valor pode ser convertido para int
                    {
                        if (numero == 0) // Se o número for 0, encerra o programa
                        {
                            Console.WriteLine("\nNúmero 0 detectado. Programa encerrado.");
                            Console.WriteLine("Pressione qualquer tecla...");
                            Console.ReadKey();                           
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
                    Console.WriteLine("Pressione qualquer tecla para voltar...");
                }
                else
                {
                    Console.WriteLine("\nNenhum número válido foi informado."); // Mensagem para lista vazia
                }
                Console.ReadKey();
            }
        }

    }
}
