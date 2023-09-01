using System.Runtime.ConstrainedExecution;

namespace Transportes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transporte t1 = new Transporte(5);

            t1.Visualizar();

            

            Terrestre t2 = new Terrestre(4, 4, 100);
            t2.Visualizar();



            Automovel al = new Automovel(10, 10, 180, "Vermelho", 1, "FVQ6589", 7);
            
            al.Visualizar();    

        }
    }
}