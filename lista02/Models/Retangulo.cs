using System;
namespace lista02

{//Largura e Altura, encapsular os atributos e calcular a área.
    class Retangulo
    {
        public float Largura
        {
            get{return largura;}
            set{if (value > 0) largura = value;}
        }
        
        public float Altura //maiusculo = get set
        {
            get{return altura;}
            set{if (value > 0) altura = value;} //Controla o acesso com validação 
        }
        private float altura; //minusculo private
        private float largura; //guarda os dados reais (ocultos)

        public Retangulo(float largura, float altura) //Construtor Inicializa o objeto com valores
        {
            Altura = altura;
            Largura = largura;
        }
        public float CalcularArea()
        {return altura * largura;}
    }
}
