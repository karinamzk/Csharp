using System.ComponentModel.Design;

namespace atividade04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, genero, dev;
            int back = 0;
            int mulherfront = 0, homemmob40 = 0, naobimenores30 = 0, participantes = 0;
            string continua;
            float mediaidade = 0;


            do
            {
                Console.WriteLine("Qual é a sua idade?: ");
                idade = Convert.ToInt32(Console.ReadLine());

                mediaidade += idade;
                    
                if (idade > 10)
                {
                    participantes++;
                }
                else
                    Console.WriteLine("Idade Inválida!");
                do
                {
                        Console.WriteLine("Qual é o seu Gênero? 1-Mulher cis/2-Homem cis/3- Não Binário/4-Mulher Trans/5-Homem Trans/6-Outros: ");
                        genero = Convert.ToInt32(Console.ReadLine());

                        do
                        {
                            Console.WriteLine("Qual é o seu Cargo? 1-Backend/2-Frontend/3-Mobile/4-FullStack: ");
                            dev = Convert.ToInt32(Console.ReadLine());

                        } while (dev < 1 || dev > 4);

                } while (genero < 1 || genero > 6);

                if (dev == 1)
                    back++;

                if ((genero == 1 || genero == 4) && dev ==2 )
                    mulherfront++;

                if ((genero == 2 || genero == 5) && dev ==3  && idade > 40)
                    homemmob40++;

                if (genero == 3 && dev==4 && idade < 30)
                    naobimenores30++;

                Console.WriteLine("Você deseja continuar ? (S/N):");
                continua = Console.ReadLine().ToUpper();

            } while (continua.Equals("S"));

            Console.WriteLine($"Total de pessoas desenvolvedoras Backend:{back}");
            Console.WriteLine($"Total de Mulheres Cis e Trans desenvolvedoras Frontend: {mulherfront}");
            Console.WriteLine($"Total de Homens Cis e Trans desenvolvedores Mobile maiores de 40 anos: {homemmob40}");
            Console.WriteLine($"Total de Não Binários desenvolvedores FullStack menores de 30 anos: {naobimenores30} ");
            Console.WriteLine($"Total de participantes da pesquisa: {participantes}");
            Console.WriteLine($"A Média de idade dos participantes da pesquisa {mediaidade/participantes}: ");
        }
    }
}