using Atividade06.NovaPasta;

namespace Atividade06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cursos curso1 = new Cursos("Audiovisual", "Tecnologo", 0001, 2000, "2 anos");

            Cursos curso2 = new Cursos("Letras", "Licenciatura",0002, 3000, "4 anos");

            curso1.Visualizar();

            curso2.Visualizar();
        }
    }
}