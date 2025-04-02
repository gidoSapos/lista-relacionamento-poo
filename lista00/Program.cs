using System;
using aula00;
namespace lista00; 
class Program
{
    static void Main(String[] args) 
    { 
       Somatorio obj = new Somatorio();                         //instancia um novo objeto
       Console.WriteLine("Insira o número que deseja somar: ");
       int numero = int.Parse(Console.ReadLine());
       Console.WriteLine(obj.Sum(numero)); 

       LivroNotas objeto = new LivroNotas();
       Console.WriteLine($"Sua nota é : {objeto.Pontuacao()}");

       Relogio i = new Relogio();
       Console.WriteLine($"Milisegundos pós meia-noite: {i.Milisegundos()}");
    }
}