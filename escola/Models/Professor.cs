namespace Models;
public class Professor : Pessoa // Herança
{
    private string Disciplina; // Atributo
    public Professor (string nome, int idade, string disciplina) : base(nome, idade) //Construtor, Parametros, Herança da base pessoa
    {
        this.Disciplina = disciplina; //Como Disciplina é privado tem que chamar ela usando isso aqui
    }
    public void Ensinar() // Construtor
    {
        Console.WriteLine("Estou ensinando..."); //Ao chamar ele vai parecer estou ensinando
    }
}