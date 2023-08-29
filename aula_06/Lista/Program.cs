using System;

namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> notas = new List<double>();
            
            //Adicionar novos elementos 

            notas.Add(7.0);
            notas.Add(5.0);
            notas.Add(4.0);
            notas.Add(7.0);
            notas.Add(10.0);

            //Listar todos os elementos
            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            // Indice de um elemento
            Console.WriteLine("Posição da nota 4.0:" + notas.IndexOf(4.0));

            // Checar se o elemento existe 
            Console.WriteLine("Posição da nota 4.0:" + notas.Contains(4.0));
            

            notas.Remove(7.0);

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }
            Console.WriteLine(" ");

            Console.WriteLine("Posição da nota 10.0" + notas.IndexOf(10.0));

            Console.WriteLine(" ");

            Console.WriteLine("Quantos elementos tem a nossa lista" + notas.Count);

            notas.Sort();

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            Console.WriteLine(" ");
            // Ordenação de Elementos
            notas.Reverse();

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            //Alteração da nota
            Console.WriteLine(" ");
            notas[0] = 9.0;

            // Var verifica qual é o tipo da variavel 
            foreach (var nota in notas)
            {
                Console.WriteLine(nota);
            }

        }
    }
}