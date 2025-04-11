namespace Models;
class Quadrado : Forma
{
    public double Lado { get; set; }

    public override double CalcularArea()
    {
        return Lado * Lado;
    }
}