using System;

namespace lista00;
class Somatorio
{
    public string Sum(int numero)
    {
        int soma = 0;                                             // criando a variavel soma que armazenará a soma do numero
        List<int> numeros = new List<int> {};                     // eu não vou mentir que tive que aprender um pouco sobre lista antes de começar o código, mas aprendi um pouco

        for (int i = numero; i >= 0; i--)                         // a estrutura de for no c# é assim: (inicialização, condição e atualização).                 
        {                                                         // Criei a variavel i que começa com o numero digitado, depois a condição é que                                    
            soma += i;                                            // vai somando até que o i seja maior ou igual a 0                                         
            numeros.Add(i);                                       // loop continue até que o i seja maior ou igual a 0, a cada loop vai diminuir um número (por isso o i--)
        }
        return $"{numero} -> {soma} ({string.Join(" + ", numeros)})"; // esse string.Join() e o numeros.Add() tive que dar uma pesquisada porquê tava fazendo igual no py com .append() 
    }
}