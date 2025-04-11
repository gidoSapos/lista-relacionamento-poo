namespace Models;

class DVD : Midia
{
    public override void ExibirDetalhes()
    {
        Console.WriteLine($"DVD: {Titulo} - 160 minutos de filme");
    }
}