namespace Models;
class Funcionario
{
    public string ?Nome { get; set; }
    public double Salario { get; set; }

    public virtual void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}\nSalário: R${Salario}");
    }
}