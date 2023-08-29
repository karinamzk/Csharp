namespace atividade_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> dados = new HashSet<int>();
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Entre com os dados: ");
                dados.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine(" ");

            foreach (int listadados in dados)
            {
                Console.WriteLine(listadados);
            }
        }
    }
}