namespace Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilha = new Stack<string>();

            //Pilha ele ordena o ultimo como o primeiro da pilha

            pilha.Push("Breno");
            pilha.Push("Eduardo");
            pilha.Push("Julia");
            pilha.Push("Leonardo");
            pilha.Push("Gaspar");

            //tira o primeiro da lista com o Dequeue

            pilha.Pop();

            foreach (var nome in pilha)
            {
                Console.WriteLine(nome);
            }

            // Mostra quem é o primeiro 

            Console.WriteLine("Quem é o primeiro da pilha? " + pilha.Peek());

            // O Contains mostra se alguem esta na pilha 

            Console.WriteLine("O Gaspar entrou na pilha? " + pilha.Contains("Gaspar"));

            // Mostra o número de pessoas na pilha

            Console.WriteLine("O número de pessoas na pilha? " + pilha.Count);
        }
    }
}