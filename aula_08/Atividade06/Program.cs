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

            CursoLivre Cl1 = new CursoLivre("Podcast","Curso Livre", 0003, 500, "6 horas", "B9-Podcast");

            Cl1.Visualizar();
            

            CursoLivre Cl2 = new CursoLivre("Oficina de Escrita Literária","Curso Livre", 0004, 500, "2 encontros", "Editora Globo");

            Cl2.Visualizar();

        }
    }
}