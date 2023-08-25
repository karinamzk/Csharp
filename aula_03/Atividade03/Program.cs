using System.ComponentModel.Design;

namespace Atividade03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome, InputDoou;
            int idade;
            bool doou;

            Console.WriteLine("Escreva o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Escreva sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18 && idade <= 59)
            {
                Console.WriteLine($"{nome} está apto(a) a doar sangue!");
            }

            else if (idade >= 60 && idade <= 69)
            {
                Console.WriteLine("Você já doou sangue antes? Digite [1] para sim | Digite [2] para não");
                InputDoou = Console.ReadLine();

                if (InputDoou.Equals("1") || InputDoou.Equals("2"))
                {
                    doou = InputDoou.Equals("1");

                    if (doou)
                    {
                        Console.WriteLine($"{nome} está apto(a) a doar sangue!");
                    }
                    else
                    {
                        Console.WriteLine($"{nome} não está apto(a) a doar sangue!");
                    }
                }
                else
                {
                    Console.WriteLine($"{nome} Você digitou uma opção inválida! ");
                }


            }
            else
                Console.WriteLine($"{nome} não está apto(a) a doar sangue ");

        }
    }
}