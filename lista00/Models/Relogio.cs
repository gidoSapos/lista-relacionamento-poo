namespace lista00;
class Relogio
{

    public double Milisegundos()
    {
        Console.WriteLine("Insira as horas pós meia-noite: ");
        int hora = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Insira os minutos pós meia-noite: ");
        int minuto = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Insira os segundos pós meia-noite: ");
        int segundo = Int32.Parse(Console.ReadLine());

        if(hora < 0 || hora > 23)
        {
            Console.WriteLine("Hora invalida");
            return -1;
        }
        else if (minuto < 0 || minuto > 59)
        {
            Console.WriteLine("Minuto invalido");
            return -1;
            
        }
        else if (segundo < 0 || segundo > 59)
        {
            Console.WriteLine("Segundo invalido");
            return -1;
        }
        double milisegundos = (hora * 3600000) + (minuto * 60000) + (segundo * 1000);
        return milisegundos;
    } 
}