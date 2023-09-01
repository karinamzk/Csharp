using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01.NovaPasta
{
    public class Cliente
    {
        private string nome = string.Empty;
        private int id;
        private string nascimento;
        private string telefone;
        private string email;

        public Cliente(string nome, int id, string nascimento, string telefone, string email)
        {
            this.nome = nome;
            this.id = id;
            this.nascimento = nascimento;
            this.telefone = telefone;
            this.email = email;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }


        public int GetId() 
        {
            return id;  
        }

        public void SetId(int id)
        {
            this.id = id;
        }


        public string GetNascimento()
        {
            return nascimento;
        }

        public void SetNascimento(string nascimento)
        {
            this.nascimento = nascimento;
        }


        public string GetTelefone()
        {
            return telefone;
        }
        public void SetTelefone(string telefone)
        {
            this.telefone = telefone;
        }


        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public virtual void Visualizar()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("Dados do usuario");
            Console.WriteLine("********************************");
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Id : {this.id}");
            Console.WriteLine($"Data de nascimento : {this.nascimento}");
            Console.WriteLine($"Telefone: {this.telefone}");
            Console.WriteLine($"Email : {this.email}");
        }
    }
}
