namespace Atividade05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            float valor, quantidade;
            string nomeproduto;

            Console.WriteLine("1 - Cachorro Quente");
            Console.WriteLine("2 - x - Salada");
            Console.WriteLine("3 - x - Bacon");
            Console.WriteLine("4 - Bauru");
            Console.WriteLine("5 - Refrigerante");
            Console.WriteLine("6 - Suco de laranja");

            Console.WriteLine("Digite o código do produto: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual a quantidade desejada? ");
            quantidade = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    valor = (10f * quantidade);
                    nomeproduto = "Cachorro Quente";
                    break;
                case 2:
                    valor = (15f * quantidade);
                    nomeproduto = "x - Salada";
                    break;
                case 3:
                    valor = (15f * quantidade);
                    nomeproduto = " x - Bacon";
                    break;
                case 4:
                    valor = (12f * quantidade);
                    nomeproduto = "Bauru";
                    break;
                case 5:
                    valor = (8f * quantidade);
                    nomeproduto = "Refrigerante";
                    break;
                default:
                    valor = (13f * quantidade);
                    nomeproduto = "Suco de laranja";
                    break;
            }

            Console.WriteLine($"Seu pedido, {nomeproduto} deu o total de R$ {valor}");

        }
    }   

}