namespace Models;

class Gerente : Funcionario
{
    public override void ExibirDados()
    {
        double salarioComBonus = Salario + 2000;
        Console.WriteLine($"Gerente: {Nome}\nSalário com bônus: R${salarioComBonus}");
    }
}