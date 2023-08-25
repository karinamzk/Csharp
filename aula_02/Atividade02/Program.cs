namespace Atividade02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, media;
            string nomealuno;

            Console.WriteLine("Nome do aluno: ");
            nomealuno = Console.ReadLine();

            Console.WriteLine("Escreva a nota 1: ");
            nota1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Escreva a nota 2: ");
            nota2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Escreva a nota 3: ");
            nota3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Escreva a nota 4: ");
            nota4 = Convert.ToSingle(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4)/4;

            Console.WriteLine("Média do aluno "+ nomealuno + " é:" + media);
         
        }
    }
}