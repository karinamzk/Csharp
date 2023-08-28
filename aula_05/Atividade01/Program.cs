using System.ComponentModel.Design;

namespace Atividade01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };
            int resultado = 0;

            Console.WriteLine($"Escreva o número do indice desejavel:");
            resultado = Convert.ToInt32(Console.ReadLine());

            for (int indice = 0; indice < vetor1.Length; indice++)
            {
                if (resultado == vetor1[indice])
                {
                    Console.WriteLine($"O numero {resultado} está localizado na posição {indice}");
                }
            }

            if (resultado > 10 || resultado < 0)
            {
                Console.WriteLine($"O número {resultado} não foi encontrado!");
            }
        }
    }
}