using System;

namespace Models
{
    public class Escola
    {
        private string Nome;
        private string Endereco;
        private List<Turma> Turmas = new List<Turma>();
        private Diretoria Diretoria;
        public Escola(string nome, string endereco, Diretoria diretor)
        {
        this.Nome = nome;
        this.Endereco = endereco;
        this.Diretoria = diretor;
        }
        public void AdicionarTurma(Turma turma) => this.Turmas.Add(turma);
        public void ListarTurmas()
        {
            Console.WriteLine($"Escola: {this.Nome}\nTurmas cadastradas:");
            foreach (Turma t in this.Turmas)
            {
                Console.WriteLine($"- {t.GetType().Name}");
            }
        }
        public void ExibirInfo()
        {            
            Console.WriteLine($"Escola: {Nome}\nEndereço: {Endereco}");
            Diretoria.ExibirDiretor();
        }
    }
}