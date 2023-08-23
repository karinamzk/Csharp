namespace Atividade01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario, abono, novosalario;

            Console.WriteLine("Escreva o Salario:");
            salario = Convert.ToSingle(Console.ReadLine( ));

            Console.WriteLine("Escreva o Abono:");
            abono = Convert.ToSingle(Console.ReadLine());

            novosalario = salario + abono;

            Console.WriteLine("Seu novo salario é: " + novosalario); 
            
        }
    }
}