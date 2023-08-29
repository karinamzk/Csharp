using System;

namespace Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> setnomes = new HashSet<string>()
            {
                "Allan",
                "Robson",
                "João",
                "Allan",
                "Robson",
                "Ingrid",
            };
            
            foreach (var nome in setnomes)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("");

            setnomes.Add("Samantha");
            setnomes.Add(null);
            setnomes.Add("Julia");


            foreach (var nome in setnomes)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("O nome Julia existe: " + setnomes.Contains("Julia"));

            setnomes.Remove("João");

            Console.WriteLine("");

            foreach (var nome in setnomes)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("");


            //Converter um HashSet para uma lista 

            List<string> hashlist = setnomes.ToList ();

            hashlist.Sort ();

            Console.WriteLine("");

            foreach (var hash in hashlist)
            {
                Console.WriteLine(hash);
            }
        }
    }
}