namespace Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();

            fila.Enqueue("Breno");
            fila.Enqueue("Eduardo");
            fila.Enqueue("Julia");
            fila.Enqueue("Leonardo");
            fila.Enqueue("Gaspar");

            //tira o primeiro da lista com o Dequeue

            fila.Dequeue();
            
            foreach (var nome in fila)
            {
                Console.WriteLine(nome);
            }

            // Mostra quem é o primeiro 

            Console.WriteLine("Quem é o primeiro da fila? "+ fila.Peek());

            // O Contains mostra se alguem esta na fila 

            Console.WriteLine("O Gaspar entrou na fila? " + fila.Contains("Gaspar"));

            // Mostra o número de pessoas na fila

            Console.WriteLine("O número de pessoas na fila? " + fila.Count);

           
        }
    }
}