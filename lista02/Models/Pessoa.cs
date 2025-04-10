namespace lista02;

class Pessoa
{
    private string nome;
    public string Nome {get; set;}        
    private int idade;
    public int Idade {get; set;}       
    public int IdadeEmDias()
    {
        return idade * 365;
    }

    public Pessoa()
    {
        Nome = nome; 
        Idade = idade;
    }
}
