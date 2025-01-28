using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BLOCO 1: Entrada do usuário
            // Solicita ao usuário que insira a quantidade de números que ele deseja processar.
            Console.Write("Digite a quantidade de números que deseja processar: ");

            // Console.Write: Exibe uma mensagem no console para o usuário.
            // Console.ReadLine(): Lê a entrada do usuário como uma string.
            // int.TryParse: Tenta converter a string para um número inteiro.
            // - Se a conversão falhar ou se a entrada for menor ou igual a 0, exibe uma mensagem de erro e encerra o programa.
            if (!int.TryParse(Console.ReadLine(), out int quantidade) || quantidade <= 0)
            {
                Console.WriteLine("Erro: A quantidade deve ser um número inteiro positivo."); // Mensagem de erro para entrada inválida.
                return; // Encerra o programa porque a entrada é inválida.
            }

            // BLOCO 2: Loop para processar os números
            // Inicia um loop para processar cada número inserido pelo usuário.
            for (int i = 1; i <= quantidade; i++) // Executa o loop 'quantidade' de vezes.
            {
                // Solicita que o usuário insira um número para calcular o fatorial.
                Console.Write($"\nDigite o número {i}: ");

                // Console.Write: Exibe uma mensagem no console para que o usuário insira o número.
                // Console.ReadLine(): Lê a entrada do usuário como uma string.
                // int.TryParse: Tenta converter a string para um número inteiro.
                // - Se a conversão falhar ou se o número for negativo, exibe uma mensagem de erro e permite que o usuário tente novamente.
                if (!int.TryParse(Console.ReadLine(), out int numero) || numero < 0)
                {
                    Console.WriteLine("Erro: Somente números inteiros não-negativos são aceitos."); // Mensagem de erro para entrada inválida.
                    i--; // Volta uma posição no contador para que o usuário insira um valor válido.
                    continue; // Reinicia o loop para solicitar novamente o número.
                }

                // Chama o método 'CalcularFatorial' para calcular o fatorial do número inserido.
                long fatorial = CalcularFatorial(numero); // Calcula o fatorial do número atual.

                // Exibe o resultado do fatorial no console.
                // Console.WriteLine: Exibe a mensagem com o resultado formatado.
                Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
            }

            // BLOCO 3: Finalização do programa
            // Após processar todos os números, exibe uma mensagem de conclusão.
            Console.WriteLine("\nProcessamento concluído. Pressione qualquer tecla para sair...");
            // Console.ReadKey: Aguarda o usuário pressionar uma tecla antes de encerrar o programa.
            Console.ReadKey();
        }

        // BLOCO 4: Método para calcular o fatorial
        // Método que calcula o fatorial de um número inteiro não negativo.
        static long CalcularFatorial(int n)
        {
            long resultado = 1; // Inicializa o resultado do fatorial como 1 (base do cálculo).

            // Multiplica os números de 1 até 'n' para calcular o fatorial.
            for (int i = 1; i <= n; i++)
            {
                resultado *= i; // Multiplica o resultado atual pelo número 'i'.
            }

            return resultado; // Retorna o resultado do fatorial.   
        }
    }
}
