using System;
namespace lista02
{
    class Menu
    {
        public static void Mostrar()
        {
            bool continuar = true;
            while (true)
            {
                string decoracao = "*¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨*";
                Console.WriteLine(decoracao);
                Console.WriteLine("Bem vindo ao menu de escolhas!...........");
                Console.WriteLine("Se você deseja calcular temperaturas - 1");
                Console.WriteLine("Calcular área de um circulo          - 2");
                Console.WriteLine("Calcular média de duas notas         - 3");
                Console.WriteLine("Depositar na conta bancária          - 4");
                Console.WriteLine("Calcular salário com descontos       - 5");
                Console.WriteLine("Calcular área de um retângulo        - 6");
                Console.WriteLine("Verificar sua idade em dias          - 7");
                Console.WriteLine("Cadastrar um novo usuário            - 8");
                Console.WriteLine("Sair do programa ><                  - 0");
                Console.WriteLine("Escolha uma opção!.......................");
                bool conversao = int.TryParse(Console.ReadLine(), out int opcao);
                
                if (!conversao)
                {
                    Console.WriteLine("Opção inválida! digite um número de 0 a 8");
                    Console.ReadKey();
                    continue;
                }

                switch(opcao)
                {

                    case 1:
                        Console.Clear();
                        Console.WriteLine(decoracao);
                        Console.WriteLine("...Chamando conversor de temperaturas!...");
                        Console.WriteLine("Conversão em Celsius ou Fahrenheit? (F/C)");
                        string escolha = Console.ReadLine().ToUpper();

                        Console.WriteLine("Qual o grau que deseja calcular?");
                        float temperatura = float.Parse(Console.ReadLine());
                        Temperatura temp1 = new Temperatura();

                        if (escolha == "C") { Console.WriteLine($"Aqui está o resultado chefia: {temp1.CelToFah(temperatura):F2}°C"); }
                        else if (escolha == "F") { Console.WriteLine($"Resultadoide: {temp1.FahToCel(temperatura):F2}°F"); }
                        else { Console.WriteLine("Opção Inválida! Digite C ou F."); }
                        break;


                    case 2:
                        Console.Clear();
                        Console.WriteLine(decoracao);
                        Console.WriteLine(".Chamando calculador área de um circulo!.");
                        Console.WriteLine("Qual o raio que deseja calcular?");
                        float raio = float.Parse(Console.ReadLine());

                        Circulo bola = new Circulo(raio);
                        Console.WriteLine($"Raio: {bola.Raio}\nÁrea: {bola.Area()}");
                        break;


                    case 3:
                        Console.Clear();
                        Console.WriteLine(decoracao);
                        Console.WriteLine("..Calculadora de média de duas notas..");
                        Console.WriteLine("Insira a primeira nota..................:");
                        float nota1 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Insira a segunda nota...................:");
                        float nota2 = float.Parse(Console.ReadLine());
                        Aluno media = new Aluno(nota1, nota2);
                        Console.WriteLine($"Média: {media.Media()}");
                        break;


                    case 4:
                        Console.Clear();
                        Console.WriteLine(".....Depositadora de conta bancária!.....");
                        Console.WriteLine("Você deseja depositar ou sacar?     (D/S)");
                        string deseja = Console.ReadLine().ToUpper();

                        Console.WriteLine("Qual valor deseja depositar?");
                        float saldo = float.Parse(Console.ReadLine());
                        ContaBancaria conta = new ContaBancaria(saldo);

                        if (deseja == "D") { Console.WriteLine("Ativando modo deposito . . ."); conta.Depositar(saldo); Console.WriteLine($"Saldo atual: {saldo}"); }
                        else if(deseja == "S") { Console.WriteLine("Ativando modo saldo. . ."); Console.WriteLine(conta.Sacar()); }
                        break;


                    case 5:
                        Console.Clear();
                        Console.WriteLine(".....Calcular salário com descontos!.....");
                        Console.WriteLine("Informe seu salário bruto...............:");
                        float salario = float.Parse(Console.ReadLine());
                        Console.WriteLine("Me diga seu nome por obséquio...........:");
                        string nome_emp = Console.ReadLine();

                        Funcionario empregado = new Funcionario(nome_emp, salario);
                        Console.WriteLine($"Olá {empregado.Nome}\nSeu salário com desconto é: {empregado.CalcularSalarioLiquido()}");
                        break;


                    case 6: 
                        Console.Clear();
                        Console.WriteLine("......Calcular área de um retângulo......");
                        Console.WriteLine("Informe a largura do retângulo:");
                        float largura = float.Parse(Console.ReadLine());

                        Console.WriteLine("Informe a altura do retângulo:");
                        float altura = float.Parse(Console.ReadLine());

                        Retangulo ret = new Retangulo(largura, altura);
                        Console.WriteLine($"Área do retângulo: {ret.CalcularArea()}");
                        break;


                    case 7:
                        Console.Clear();
                        Console.WriteLine("......Verificador de idade em dias.......");
                        Console.WriteLine("Digite sua idade em anos:");
                        int idade = int.Parse(Console.ReadLine());

                        int idadeDias = idade * 365;
                        Console.WriteLine($"Você já viveu aproximadamente {idadeDias} dias!");
                        break;


                    case 8:
                        Console.Clear();
                        Console.WriteLine(".....Cadastro de novo usuário!.....");
                        Console.Write("Digite o nome de usuário: ");
                        string nomeUsuario = Console.ReadLine();
                        Console.Write("Digite a senha (mínimo 8 caracteres): ");
                        string senhaUsuario = Console.ReadLine();

                        CadastroDeUsuarios novoUsuario = new CadastroDeUsuarios(nomeUsuario, senhaUsuario);
                        novoUsuario.MostrarDados();
                        break;

                    case 0:
                        Console.WriteLine("Saindo do programa... Volte sempre <3");
                        return;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}