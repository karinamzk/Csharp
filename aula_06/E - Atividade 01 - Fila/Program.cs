namespace E___Atividade_01___Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
          
            Queue<string> fila = new Queue<string>();

            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine(" ");
            Console.WriteLine("1 - Adicionar Cliente na Fila");
            Console.WriteLine("2 - Listar todos os Clientes");
            Console.WriteLine("3 - Retirar Clientes da Fila");
            Console.WriteLine("0 - Sair");
            Console.WriteLine(" ");
            Console.WriteLine("***********************************************************************************************");

            do
            {
                Console.WriteLine("Entre com a opção desejada:");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    
                     Console.WriteLine("Adicione um nome da lista: ");
                     fila.Enqueue(Console.ReadLine( ));

                     Console.WriteLine("Cliente Adicionado!");
                   
                }

                if (opcao == 2)
                {
                    foreach (var nome in fila)
                    {
                        Console.WriteLine($"A fila contem: {nome}");
                    }
                }

                if (opcao == 3)
                {

                    if (fila != null)
                    {
                        Console.WriteLine("A fila está vazia! ");
                    }
                    for(int i = 0; i <= 0; i++)
                    {
                        Console.WriteLine("Retirar cliente da lista: ");
                        fila.Dequeue();
                    }
                }
                if (opcao == 0 )
                {
                    for (int i = 0; i <= 0; i++)
                    {
                        Console.WriteLine("Programa Finalizado");
                    }
                }

            } while (opcao == 1 && opcao <= 3);
        }
    }
}