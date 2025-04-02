public class Cachorro
{
    public string? nome;
    public string? raca;
    public int idade;
    public string Latir()
    {
        if (this.idade < 5)
        {
            return "auuauauauauuauauauauauuauauauauauuauau"
        }
        else
        {
            return "você nunca vai se aposentar."
        }
    }
}