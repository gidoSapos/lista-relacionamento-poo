namespace Models;
abstract class Midia
{
    public string ?Titulo { get; set; }
    public abstract void ExibirDetalhes();
}
