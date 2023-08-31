using Métodos_02.Namespace01;

namespace Métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero, numero2, divisao;

            Console.WriteLine("Digite o primeiro número:");
            numero = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            numero2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"{numero} + {numero2} = " + Somar(numero, numero2));
            Console.WriteLine($"{numero} - {numero2} = " + Subtrair(numero, numero2));
            Console.WriteLine($"{numero} * {numero2} = " + Multiplicar(numero, numero2));

            divisao = Dividir(numero, numero2);
            Console.WriteLine(divisao == 0 ? "Não existe Divisão por zero" : $"{numero} / {numero2}= {divisao}");

            Console.WriteLine($"{numero} ^ {numero2} = " + Potencia(numero, numero2));
            Console.WriteLine($"Raiz quadrada de {numero} = " + Raiz1(numero));
            Console.WriteLine($"Raiz quadrada de{numero2} = " + Raiz2(numero2));

            Dev();

            Class2.metodopublico();
        }
        static float Somar(float palavra, float palavra2)
        {
            return palavra + palavra2;
        }
        static float Subtrair(float numero1, float numero2)
        {
            return numero1 - numero2;
        }
        static float Multiplicar(float numero1, float numero2)
        {
            return numero1 * numero2;
        }
        static float Dividir(float numero1, float numero2)
        {
            if (numero2 > 0)
                return numero1 / numero2;
            else
                return 0;
        }
        static double Potencia(float numero1, float numero2)
        {
            return Math.Pow(numero1, numero2);
        }
        static double Raiz1(float numero1)
        {
            return Math.Sqrt(numero1);
        }
        static double Raiz2(float numero2)
        {
            return Math.Sqrt(numero2);
        }

        static void Dev()
        {
            Console.WriteLine("Criado por: Karinamzk");
        }
    }
}