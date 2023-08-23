namespace Atividade04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, cal;

            Console.WriteLine("Escreva o valor do número 1: ");
            n1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Escreva o valor do número 2: ");
            n2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Escreva o valor do número 3: ");
            n3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Escreva o valor do número 4: ");
            n4 = Convert.ToSingle(Console.ReadLine());

            cal = (n1 * n2) - (n3 * n4);
            Console.WriteLine(cal);
        }
    }
}