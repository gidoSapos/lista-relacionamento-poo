/* se quiser comentar muita coisa é só usar esse troço
quando divide numero inteiro e dá float, o resultado vai depender do tipo da variavel inicial.a
&& e , || ou


using System;
using System.Reflection.Metadata;             //Modulos ou pacotes, como C# é grande, os desenvolvedores e dividiram dependenvdo do uso, se for criar um game ou app
                                              //vc chama dependnedo. Se tudo fosse junto o app ia demorar a executar e ia pesar muito. Vc só insere oq vai usar
                                              //o System é pra manipular o pc do usuario, ex Hora. É maneiro vc saber os System pq é realmente versatil.
namespace pratica
{        //essas duas linhas pra baixo sao meio complicadas e tem a ver a programação orientada a objetos
    class Program //aqui dentro vão ficar todas as funções
    {        //oq importa mesmo é oq tem aqui dentro, esse é o inicio do programa.
        static void Main(string[] args)
        { //é a função principal (Main), todo o codigo que voce coloca aqui dentro é executado primeiro quando alg clica na versão .exe
                                        //deve ser meio obrigatorio

            var yoshi = 1321.123f; // o C# induz qual o tipo da variaveo, mas é bom não mudar o tipo dela depois. É melhor definir 
            dynamic fruta = "pera"; // não indicado!!! o c# fica checando qual o tipo dela
            const string polly_pocket = "Giovanna Paes Bastos"; //constante é algo que nunca vai mudar, é bom pra codigos muito grandes, onde uma info nunca pode mudar
            
            Console.WriteLine("Escreva sua idade: ");
            int idade = int.Parse(Console.ReadLine());  // Detecta oq o usuario escreveu, o programa vai rodar ate o user inserir algo n terminal
            Console.WriteLine("QUal o seu nome??");
            string nome = Console.ReadLine();

            if (idade > 10 && nome == "tatupirim")
            {
                Console.WriteLine("Você é o maior cacique da nossa tribo.");
            }
            else if (idade < 10 || nome == "oshi")
            {
                Console.WriteLine("Saia daqui carniça");
            }
            else
            {
                Console.WriteLine("Você ser só gente.");
            }

            Gigi_Gamer(false, "luliska");
        } 

        static string Gigi_Gamer(bool matou, string user) //todas as funções começam com o static. O void diz que o retorno da função é nada. Dentro dos parenteses são os parametros.
        {                                                 //quando define o tipo no lugar do void é obrigatorio retornar algo
            if (matou == true)
            {
                return "Você foi obliterado pela Gigi Gamer";
            }

            else
            {
                Console.WriteLine("Sofra, alma penada!");
                matou = true;
                return $"O jogador {user} foi morto {matou} pela Gigi Gamer";
            }
        }
    }
}
*/