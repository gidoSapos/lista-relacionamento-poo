using System;

namespace Aula06
{
    class Program
    {
        static void Main(String[] args)
        {// Objetos... ISSO é programação orientada a objetos
            Pessoa obj = new Pessoa();
            obj.ColetarDados();
            Console.WriteLine(obj.MensagemImc());
        }
    }
}