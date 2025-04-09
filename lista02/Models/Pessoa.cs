namespace lista02
{
    class Pessoa
    {
        private string nome;
        public string Nome
        {
            get{return nome;}
            set{nome = value;}
        }        
        private int idade;
        public int Idade
        {
            get{return idade;}
            set{idade = value;}
        }

        public string Mensagem()
        {
            return $"Olá {nome}, você tem mais ou menos {idade - 100} anos, em tempo de vida.";
        }
        public int idadeEmAnos()
        {
            return idade * 12;
        }

        public Pessoa()
        {
            Nome = nome; 
            Idade = idade;
        }
    }
}
