namespace Models;
class ContaPoupanca : ContaBancaria
{
    public override void Sacar(double valor)
    {
        if (valor <= Saldo)
            Saldo -= valor;
        else
            Console.WriteLine("Saldo insuficiente. Pobreta");
    }
}