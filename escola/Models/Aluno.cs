namespace Models;
public class Aluno : Pessoa //aluno ta herdando pessoa
{
    private int Matricula;
    public Aluno(int matricula, string nome, int idade) : base(nome, idade)
    {
        this.Matricula = matricula;
    }
    public void Estudar()
    {
        Console.WriteLine("Aumentando o tamanho do cerecbro estudando...");
    }
    
 }