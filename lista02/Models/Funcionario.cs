namespace lista02
{
    class Funcionario
    {
        private string nome;
        public string Nome
        {
            get{return nome;}
            set{nome = value;}
        }
        private float salariobruto;
        public float Salariobruto
        {
            get{return salariobruto;}
            set{if (value > 0) salariobruto = value;}
        }

        public Funcionario(string nome, float salariobruto)
        {
            Nome = nome;
            Salariobruto = salariobruto;
        }

        public float CalcularSalarioLiquido()
        {
            float inss = salariobruto * 0.11f;
            float ir = salariobruto * 0.15f; 
            float salario = salariobruto - ir - inss;
            return salario;
        }
    }
}
