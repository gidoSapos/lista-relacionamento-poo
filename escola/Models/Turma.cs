using System;

namespace Models
{
    public class Turma
    {
        private string Nome;
        private List<Aluno> Alunos = new List<Aluno> ();
        private List<Professor> Professores = new List<Professor> ();
        public Turma(string nome) => this.Nome = nome; //def mystery
        public void AdicionarAluno(Aluno aluno) => this.Alunos.Add(aluno); //add os aluno
        public void AdicionarProfessor(Professor professor) => this.Professores.Add(professor);

        public void ListarAlunos()
        {
            Console.WriteLine($"Turma: {this.Nome}\n");
            foreach(Aluno aluno in this.Alunos) //ta listando todos os alunos
            {
                aluno.ExibirInfo();
            }
        }
        public void ListarProfessores()
        {
            Console.WriteLine($"Turma {this.Nome}\n");
            foreach (Professor professor in this.Professores)
            {
                professor.ExibirInfo();
            }
        }
    }
}