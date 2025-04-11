namespace Models;
class CD : Midia
{
    public override void ExibirDetalhes()
    {
        Console.WriteLine($"CD: {Titulo} - 20 faixas");
    }
}