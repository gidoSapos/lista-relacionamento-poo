namespace Models;
class ContaCorrente : ContaBancaria
{
    public override void Sacar(double valor)
    {
        double taxa = 2.50;
        if (valor + taxa <= Saldo)
            Saldo -= (valor + taxa);
        else
            Console.WriteLine("Saldo insuficiente (com taxa).");
    }
}
