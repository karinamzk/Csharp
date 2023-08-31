using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos_02
{
    public class Class1
    {
        public static void metodopublico()
        {
            Console.WriteLine("Método Público - Classe 01");
        }

        internal static void metodointerno()
        {
            Console.WriteLine("Método Internal - Classe 01");
        }
        protected static void metodoprotegido()
        {
            Console.WriteLine("Método Protegido - Classe 01");
        }
        private static void metodoprivado()
        {
            Console.WriteLine("Método Privado - Classe 01");
        }
    }
}
