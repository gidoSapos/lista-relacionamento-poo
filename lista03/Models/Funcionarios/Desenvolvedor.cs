namespace Models;

class Desenvolvedor : Funcionario
{
    public override void ExibirDados()
    {
        double salarioComBonus = Salario + 1000;
        Console.WriteLine($"Dev: {Nome}\nSalário com bônus: R${salarioComBonus}");
    }
}