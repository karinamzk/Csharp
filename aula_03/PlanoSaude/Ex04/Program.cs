using System.ComponentModel.Design;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? palavra1, palavra2, palavra3;

            Console.WriteLine("Digite a primeira palavra: ");
            palavra1 = Console.ReadLine();

            Console.WriteLine("Digite a segunda palavra: ");
            palavra2 = Console.ReadLine();

            Console.WriteLine("Digite a terceira palavra: ");
            palavra3 = Console.ReadLine();

            if (palavra1 is not null && palavra2 is not null && palavra3 is not null)
            {
                if (palavra1.Equals("vertebrado"))
                {
                    if (palavra2.Equals("ave"))
                    {
                        if (palavra3.Equals("carnivoro"))
                        {
                            Console.WriteLine("Águia");
                        }
                        else
                        {
                            Console.WriteLine("Pomba");
                        }
                    }
                }
                else
                {
                    if (palavra2.Equals(" "))
                    {
                        if (palavra3.Equals(" "))
                        {
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            Console.WriteLine(" ");
                        }
                    }

                }
            }
            else
            {
                if (palavra2.Equals("onivoro"))
                {
                    if (palavra3.Equals("onivoro "))
                    {
                        Console.WriteLine("Minhoca");
                    }
                    else
                    {
                        Console.WriteLine("Sanguessuga");
                    }
                }
            }
        }
        
    }
}