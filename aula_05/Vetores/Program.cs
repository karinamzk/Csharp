﻿namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor01 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] vetor02 = new int[5];

            string[] vetor03 = {"Allan", "Ingrid", "shomara", "Karina", "João", "Jacqueline", "Karina"};

            for (int indice = 0; indice < 10; indice++)
            {
                Console.WriteLine($"vetor01[{indice}] = {vetor01[indice]}");
            }

            /*Console.WriteLine("");

            for (int indice = 0; indice < 5; indice++)
            {
                Console.WriteLine($"vetor02[{indice}] = ");
                vetor02[indice] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");

            Array.Sort(vetor02);

            for (int indice = 0; indice < vetor02.Length; indice++)
            {
                Console.WriteLine($"vetor02[{indice}] = {vetor02[indice]}");
            }

            Console.WriteLine("");
            Array.Reverse(vetor02);

            for (int indice = 0; indice < vetor02.Length; indice++)
            {
                Console.WriteLine($"vetor02[{indice}] = {vetor02[indice]}");
            }

            Array.Sort(vetor03);

            for (int indice = 0;indice < vetor03.Length; indice++) 
            { 
                Console.WriteLine($"vetor03[{indice}] = {vetor03[indice]}");
            }

            Console.WriteLine(Array.IndexOf(vetor03, "Karina"));
            Console.WriteLine(Array.BinarySearch(vetor03, "Karina"));

            for (int indice = 0; indice < vetor01.Length; indice++)
            {
                if (vetor01[indice] % 2 == 0)
                {
                    Console.WriteLine($"vetor01[{indice}] = {vetor01[indice]}");
                }*/
                
            
        }
    }
}