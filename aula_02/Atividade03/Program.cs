using System;

namespace Atividade03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float bruto, noturno, extras, descontos, liquido;

            Console.WriteLine("Escreva Salário Bruto: ");
            bruto = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Escreva Adicional Noturno: ");
            noturno = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Escreva horas extras: ");
            extras = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Escreva seus descontos: ");
            descontos = Convert.ToSingle(Console.ReadLine());

            liquido = bruto + noturno + (extras*5) - descontos;
            Console.WriteLine("Seu salario liquido é:" + liquido);

        }
    }
}