using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos_02.Namespace01
{
    public class Class2
    {
        public static void metodopublico()
        {
            Console.WriteLine("Método Público - Classe 02");
        }

        internal static void metodointerno()
        {
            Console.WriteLine("Método Internal - Classe 02");
        }
        protected static void metodoprotegido()
        {
            Console.WriteLine("Método Protegido - Classe 02");
        }
        private static void metodoprivado()
        {
            Console.WriteLine("Método Privado - Classe 02");
        }
    }
}
