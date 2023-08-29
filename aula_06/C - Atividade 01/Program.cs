using System.Runtime.ExceptionServices;

namespace C___Atividade_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> cores = new List<string>();

            for (int i=0; i <= 4; i++)
            { 
                Console.WriteLine("Escreva as cores: ");
                cores.Add(Console.ReadLine( ));   
            }

            Console.WriteLine(" ");

            foreach (string listacores in cores) 
            {
                Console.WriteLine(listacores);
            }

            Console.WriteLine(" "); 

            cores.Sort();

            foreach (string listacores in cores)
            {
                Console.WriteLine(listacores);
            }

        }
    }
}