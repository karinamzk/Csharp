using atividade01.NovaPasta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace atividade01
{
    public class PessoaFisica : Cliente
    {
        private string cpf;
        public PessoaFisica(string nome, int id, string nascimento, string telefone, string email, string cpf)
            : base(nome, id, nascimento, telefone, email)
        {
            this.cpf = cpf;
        }

        public string GetCpf()
        {
            return cpf;
        }

        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"CPF {this.cpf} ");
        }
       
    }
}
