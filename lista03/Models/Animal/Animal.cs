namespace Models;
class Animal
{
    public string ?Nome { get; set; }
    public int Idade { get; set; }

    public virtual void EmitirSom()
    {
        Console.WriteLine("O animal faz um som.");
    }
}