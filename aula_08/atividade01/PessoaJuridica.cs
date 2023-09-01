using atividade01.NovaPasta;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01
{
    internal class PessoaJuridica : Cliente
    {
        private string cnpj;

        public PessoaJuridica(string nome, int id, string nascimento, string telefone, string email, string cnpj)
            : base(nome, id, nascimento, telefone, email)
        {
            this.cnpj = cnpj;
        }

        public string GetCnpj()
        {
            return cnpj;
        }

        public void SetCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"CNPJ : {this.cnpj}");
        }

    }
  
        
}
