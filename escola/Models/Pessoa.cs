using System;

namespace Models
{
    public class Pessoa 
    {
        protected string? Nome;
        protected int? Idade;
        public Pessoa(string nome, int idade){
            this.Nome = nome;
            this.Idade = idade;
        }
        public virtual void ExibirInfo()
        {
            Console.WriteLine($"Nome: {this.Nome}/n Idade: {this.Idade}");
        }
        
    }
}

