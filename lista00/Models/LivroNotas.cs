using System;
namespace lista00;
class LivroNotas
{
    public string Pontuacao()
    {
        Console.WriteLine("Insira a primeira nota (1 a 100): ");
        double nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira a segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira a terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2 + nota3)/3;
        if(media >= 90 && media <= 100)
        {
            return "A";
        }
        else if(media >= 80 && media < 90)
        {
            return "B";
        }
        else if(media >= 70 && media < 80)
        {
            return "C";
        }
        else if(media >= 60 && media < 70)
        {
            return "D";
        } 
        else
        {
            return "F";
        }
    }
}