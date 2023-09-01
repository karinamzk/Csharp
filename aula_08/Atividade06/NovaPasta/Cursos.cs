using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade06.NovaPasta
{
    internal class Cursos
    {
        private string nome = string.Empty;
        private string tipo = string.Empty;
        private int id;
        private int investimento;
        private string duracao = string.Empty;

        public Cursos(string nome, string tipo, int id, int investimento, string duracao)
        {
            this.nome = nome;
            this.tipo = tipo;
            this.id = id;
            this.investimento = investimento;
            this.duracao = duracao;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome=nome;
        }



        public string GetTipo()
        {
            return tipo;
        }
        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }


        public int GetId()
        {
            return id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }


        public int GetInvestimento()
        {
            return investimento;
        }
        public void SetInvestimento(int investimento)
        {
            this.investimento= investimento;
        }


        public string Duracao()
        {
            return duracao;
        }
        public void SetDuracao(string duracao)
        {
            this.duracao = duracao;
        }

        public virtual void Visualizar()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("Dados do Cursos");
            Console.WriteLine("********************************");
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Tipo: {this.tipo}");
            Console.WriteLine($"Id: {this.id}");
            Console.WriteLine($"Investimento : {this.investimento}");
            Console.WriteLine($"Duração: {this.duracao}");

        }

    }
}
