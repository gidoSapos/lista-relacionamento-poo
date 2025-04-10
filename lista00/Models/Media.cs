using System;
namespace lista00;

class Media
{
    public bool MelhorQueMedia(int[] pontuacoesClasse, int suaPontuacao)
    {
        double soma = 0;
        foreach (int nota in pontuacoesClasse)
        {
            soma += nota;
        }

        double media = soma / pontuacoesClasse.Length;
        return suaPontuacao > media;
    }
}
