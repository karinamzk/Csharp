using Métodos_02.Namespace01;

namespace Métodos_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            metodopublico();
            metodointerno();
            metodoprotegido();
            metodoprivado();

            Class1.metodopublico();
            Class1.metodointerno();

            Class2.metodopublico();
            Class2.metodointerno();
            //Class2.metodoprotegido();//
        }

        public static void metodopublico()
        {
            Console.WriteLine("Método Público - Classe Program");
        }

        internal static void metodointerno()
        {
            Console.WriteLine("Método Internal - Classe Program");
        }
        protected static void metodoprotegido()
        {
            Console.WriteLine("Método Protegido - Classe Program");
        }
        private static void metodoprivado()
        {
            Console.WriteLine("Método Privado - Classe Program");
        }

      
    }
}