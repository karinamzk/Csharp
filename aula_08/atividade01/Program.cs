using atividade01.NovaPasta;
using System.Runtime.CompilerServices;

namespace atividade01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int id;
            string nome, telefone, email, cpf;

            id = Convert.ToInt32(Console.ReadLine());
            nome = Console.ReadLine();
            telefone = Console.ReadLine();
            email = Console.ReadLine();
            cpf = Console.ReadLine();*/

            Cliente cliente1 = new Cliente("Karina",1,"12345678", "011 95819-0926", "karinamzk@gmail.com");

            Cliente cliente2 = new Cliente("Sofia",2,"987654321", "011 2345-6789", "sofiamzk@gmail.com" );

            cliente1.Visualizar();

            cliente2.Visualizar();    
        }
    }
}