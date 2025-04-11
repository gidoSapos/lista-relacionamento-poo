using System;
namespace escola
{
    public class Menu
    {
        public static void exibir()
        {
            Console.Clear();
            Console.WriteLine("Escolha umas opção: ");
            Console.WriteLine("1 - Cadastrar Professor: ");
            Console.WriteLine("2 - Cadastrar Aluno: ");
            Console.WriteLine("3 - Cadastrar Diretor: ");
        }
        public static int escolheropcao()
        {
            string? opcao = Console.ReadLine();
            return Int32.Parse(opcao);
        }


    }
}