namespace Atividade_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome, cargos;
            float salario, reajuste;
            int cargo;

            Console.WriteLine("Escreva o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("1 - Gerente");
            Console.WriteLine("2 - Vendedor");
            Console.WriteLine("3 - Supervisor");
            Console.WriteLine("4 - Motorista");
            Console.WriteLine("5 - Estoquista");
            Console.WriteLine("6 - Técnico de TI");

            Console.WriteLine("Escreva o seu Cargo: ");
            cargo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva o seu salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            switch (cargo)
            {
                case 1:
                    reajuste = (salario * 10) / 100;
                    cargos = "Gerente";
                    break;
                case 2:
                    reajuste = (salario * 7) / 100;
                    cargos = "Vendedor";
                    break;
                case 3:
                    reajuste = (salario * 9) / 100;
                    cargos = "Supervisor";
                    break;
                case 4:
                    reajuste = (salario * 6) / 100;
                    cargos = "Motorista";
                    break;
                case 5:
                    reajuste = (salario * 5) / 100;
                    cargos = "Estoquista";
                    break;
                default:
                    reajuste = (salario * 8) / 100;
                    cargos = "Técnico de TI";
                    break;
            }
            Console.WriteLine($"O nome do colaborador: {nome}");
            Console.WriteLine($"Cargo: {cargos}");
            Console.WriteLine($"O novo salário é de R$:{salario + reajuste}");
        }
    }
}