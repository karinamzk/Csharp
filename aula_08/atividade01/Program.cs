using atividade01.NovaPasta;
using System.Runtime.CompilerServices;

namespace atividade01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int id;
            string nome, telefone, email, nascimento;

            id = Convert.ToInt32(Console.ReadLine());
            nome = Console.ReadLine();
            telefone = Console.ReadLine();
            email = Console.ReadLine();
            nascimento = Console.ReadLine();*/

            Cliente cliente1 = new Cliente("Karina",1,"12/02/1995", "011 95819-0926", "karinamzk@gmail.com");

            Cliente cliente2 = new Cliente("Sofia",2,"13/10/1998", "011 2345-6789", "sofiamzk@gmail.com" );

            cliente1.Visualizar();

            cliente2.Visualizar();

            PessoaFisica pessoaf = new PessoaFisica("Julia",3, "02/02/2000", "011 9 5846-4562","julia123@gmail.com", "116.056.156.16");

            pessoaf.Visualizar();

            PessoaFisica pessoaf2 = new PessoaFisica("Maria", 3, "02 / 02 / 1961", "011 9 5846-5846", "maria123@gmail.com", "056-056-156-16");

            pessoaf2.Visualizar();

            PessoaJuridica pessoaj = new PessoaJuridica("Marcello", 4, "14 / 10 / 1985", "011 9 5846-8461", "Marcelo123@gmail.com", "084.486.1000-1");

            pessoaj.Visualizar();

            PessoaJuridica pessoaj2 = new PessoaJuridica("Monise", 5, "25 / 01 / 1985", "011 98461-8461", "Monise123@gmail.com", "184.847.1000-1");

            pessoaj2.Visualizar();
        }
    }
}