namespace Atividade02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            string parimpar, negpov;

            Console.WriteLine("Digite o número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 00)
            {
                parimpar = "Par";
               
            }
            else
            {
                parimpar = "Impar";
               
            }

            if (num1 >= 0)
            {
                negpov = "positivo";
               
            }
            else
            {
                negpov = "negativo";
               
            }

            Console.WriteLine($"O numero {num1} é {parimpar} e {negpov}");

        }
    }
}