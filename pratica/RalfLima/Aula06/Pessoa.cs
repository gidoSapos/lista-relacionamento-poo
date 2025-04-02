using System;

namespace Aula06
{
    class Pessoa
    {
        // Atributos
        public double peso, altura;

        //Metodo para pegar informacoes
        public void ColetarDados()
        {
            Console.WriteLine("Informe sua altura:");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe seu peso: ");
            peso = double.Parse(Console.ReadLine());
        }
        
        //Metodo de Calculo
        public double Imc()
        {
            return peso/(altura * altura);
        }

        //Metodo de Mensagem
        public string MensagemImc()
        {
            double imc = Imc();
            if(Imc() < 18.5)
            {
                return $"IMC {Imc()} - Abaixo do peso.";
            }
            else if (Imc() < 25)
            {
                return $"IMC {Imc()} - Peso normal";
            } 
            else if (Imc() < 30)
            {
                return $"IMC {Imc()} - Acima do peso";
            }
            else if (Imc() < 35)
            {
                return $"IMC {Imc()} - Obesidade I";
            }
            else if (Imc() < 40)
            {
                return $"IMC {Imc()} - Obesidade II";
            }
            else
            {
                return $"IMC {Imc()} - Obesidade III";
            }
        }
    }
}