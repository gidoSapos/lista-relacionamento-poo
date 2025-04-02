using System;
using System.Security.Cryptography.X509Certificates;
namespace aula00;
class Relogio
{

    public double Milisegundos()
    {
        double milisegundo;
        Console.WriteLine("Insira as horas pós meia-noite: ");
        double hora = Double.Parse(Console.ReadLine());
        Console.WriteLine("Insira os minutos pós meia-noite: ");
        double minuto = Double.Parse(Console.ReadLine());
        Console.WriteLine("Insira os segundos pós meia-noite: ");
        double segundo = Double.Parse(Console.ReadLine());

        if(hora < 0 && hora > 23)
        {
            Console.WriteLine("Hora invalida");
        }
        else if (minuto < 0 && minuto > 59)
        {
            Console.WriteLine("Minuto invalido");
        }
        else if (segundo < 0 && segundo > 59)
        {
            Console.WriteLine("Segundo invalido");
        }
        milisegundo = (hora * 3600000) + (minuto * 60000) + (segundo * 1000);
        return milisegundo;
    } 
}