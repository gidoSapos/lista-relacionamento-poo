using System;
using System.Net.Http.Headers;
//como c# e fortemente tipado, vc tem que especificar cada coisa
class Aluno //classe vai ser algo abstrato e com molde. Comeca com Maiusculo. Dentro dela vao ter atributos ou caracteristicas que pessoas costumam ter
{   //ATRIBUTOS
    public string nome; // public e qualquer arquivo com .cs vai ter acesso ou visulizacao do meu atributo ou metodo
    public int nota1, nota2; // esse reference vai ser em que partes ja foram usadas.

    //METODOS
    public float CalculoMedia() //parece uma funcao mas nao tem static no meio MINUSCULOS
    {
        float media = (nota1 + nota2) / 2;
        return media;
    }
    public bool IsAproved()
    {
        if (CalculoMedia() > 6)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}