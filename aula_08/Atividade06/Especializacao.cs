using Atividade06.NovaPasta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade06
{
    internal class Especializacao : Cursos
    {
      
        private string mec;

        public Especializacao(string nome, string tipo, int id, int investimento, string duracao, string mec)
            : base(nome, tipo, id, investimento, duracao)
        {
            this.mec = mec;
        }

        public string GetPatrocinador()
        {
            return this.mec;
        }

        public void SetMec(string mec)
        {
            this.mec = mec;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"É aprovado pelo MEC: {this.mec}");
        }
    }
}
