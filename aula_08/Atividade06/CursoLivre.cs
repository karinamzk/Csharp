using Atividade06.NovaPasta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade06
{
    internal class CursoLivre : Cursos
    {
        private string patrocinador;

        public CursoLivre(string nome, string tipo, int id, int investimento, string duracao, string patrocinador)
            : base(nome, tipo, id, investimento, duracao)
        {
            this.patrocinador = patrocinador;
        }

        public string GetPatrocinador()
        {
            return this.patrocinador;
        }

        public void SetPatrocionador(string patrocinador)
        {
            this.patrocinador= patrocinador;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Patrocinador: {this.patrocinador}");
        }
    }
}
