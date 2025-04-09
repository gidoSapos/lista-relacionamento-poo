namespace lista02
{
    class ContaBancaria
    {   
        private float saldo;
        public float Saldo
        {
            get{return saldo;} 
            set
            {
                if (saldo >= 0)
                {
                    saldo = value;
                }
            }
        }

        public ContaBancaria(float saldo) => Saldo = saldo;
        public float Depositar(float saldo)
        {
            saldo += 100;
            return saldo; 
        }
        public string Sacar()
            {return "Já pode saca";}
        
    }
}
