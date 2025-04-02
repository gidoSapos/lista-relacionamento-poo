using System;
using Models;

class Program
{
    static void Main()
    {
        Professor diretor = new Professor("Obama", 40, "Diretor");
        Diretoria diretoria = new Diretoria(diretor);

        Escola escola =  new Escola("UNASP", "Engenheiro Coelho", diretoria);

        Turma turma1 = new Turma("3º ano B");

        Aluno aluno1 = new Aluno(127232,"Losa Felix", 18);
        Aluno aluno2 = new Aluno(208984, "Sapoide", 19);

        Professor professor1 = new Professor("Anderson Cunha Moveis Usados", 35, "Estrutura de Dados");
        Professor professor2 = new Professor("Edoardo Mensdes", 40, "POO");

        turma1.AdicionarAluno(aluno1);
        turma1.AdicionarAluno(aluno2) ;
        escola.AdicionarTurma(turma1);

        turma1.AdicionarProfessor(professor1);

        turma1.ListarAlunos();
        turma1.ListarProfessores();

        escola.ExibirInfo();
        escola.ListarTurmas();



    }
}