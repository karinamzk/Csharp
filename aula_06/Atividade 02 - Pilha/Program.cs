namespace Atividade_02___Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;


            Stack<string> livro = new Stack<string>();
                
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("*********************************");
                Console.WriteLine("                                 ");
                Console.WriteLine("     1 - Adicionar Livro na pilha");
                Console.WriteLine("     2 - Listar todos os livros  ");
                Console.WriteLine("     3 - Retirar Livros da pilha ");
                Console.WriteLine("     0 - Sair                    ");
                Console.WriteLine("                                 ");
                Console.WriteLine("*********************************");

            do
            {
                Console.WriteLine("Entre com a opção desejada:");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    for (int i = 0; i <= 0; i++)
                    {
                        Console.WriteLine("Adicione um nome da lista: ");
                        livro.Push(Console.ReadLine());

                        Console.WriteLine("Livro Adicionado!");
                    }

                }

                if (opcao == 2)
                {
                    foreach (var pilha in livro)
                    {
                        Console.WriteLine($"A fila contem:" + (pilha));
                    }
                }

                if (opcao == 3)
                {
                    if (livro != null)
                    {
                        Console.WriteLine("A pilha está vazia! ");
                    }
                    else 
                    {
                        Console.WriteLine("Retirar cliente da lista: ");
                        livro.Pop();
                    }
                }
                if (opcao == 0)
                {
                    Console.WriteLine("Programa Finalizado");
                    System.Environment.Exit(0);
                }

            } while (opcao == 1 && opcao <= 3);
        }
    }
}