using System;

namespace Models
{
    public class Diretoria
    {
        private Professor Diretor;
        public Diretoria(Professor diretor) => this.Diretor = diretor;
        public void ExibirDiretor(){
            Console.WriteLine($"Nome: {this.Diretor}");    
        }
    }
}
