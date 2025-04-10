class ContaBancaria
{
    private double saldo;
    public double Saldo
    {
        get { return saldo; }
        private set
        {
            if (value < 0)
            {
                Console.WriteLine("Saldo não pode ser negativo.");
                saldo = 0;
            }
            else
            {
                saldo = value;
            }
        }
    }
    public ContaBancaria(double saldoInicial)
    {
        Saldo = saldoInicial;
    }
    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine($"Você depositou R${valor}. Novo saldo: R${Saldo}");
        }
        else
        {
            Console.WriteLine("O valor do depósito deve ser maior que zero.");
        }
    }
        public void Sacar(double valor)
        {
            if (valor > 0)
            {
                if (valor <= Saldo)
                {
                    Saldo -= valor;  // Atualiza o saldo
                    Console.WriteLine($"Você sacou R${valor}. Novo saldo: R${Saldo}");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para o saque.");
                }
            }
            else
            {
                Console.WriteLine("O valor do saque deve ser maior que zero.");
            }
        }
}