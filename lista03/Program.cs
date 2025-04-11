namespace Models;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("\n<><><><><><><><><><> animais <><><><><><<><><><><><");
        Animal animal1 = new Cachorro { Nome = "Yoshi", Idade = 3 };
        Animal animal2 = new Gato { Nome = "Princeso", Idade = 2 };
        animal1.EmitirSom();
        animal2.EmitirSom();


        Console.WriteLine("\n<><><><><><><><><> veiculos <><><><><><<><><><><><");
        Carro carro = new Carro { Marca = "Camiãonete", Ano = 2040, Portas = 4 };
        Moto moto = new Moto { Marca = "vrumvrum", Ano = 2001, TemPartidaEletrica = true };
        Console.WriteLine($"Carro: {carro.Marca}\nAno: {carro.Ano}\nPortas: {carro.Portas}");
        Console.WriteLine($"Moto: {moto.Marca}\nAno: {moto.Ano}\nPartida Elétrica: {moto.TemPartidaEletrica}");


        Console.WriteLine("\n<><><><><><><><><><> funcionarios <><><><><><<><><><><><");
        Funcionario func1 = new Gerente { Nome = "Giovanna", Salario = 9000000 };
        Funcionario func2 = new Desenvolvedor { Nome = "Luisa", Salario = 900000000 };
        func1.ExibirDados();
        func2.ExibirDados();


        Console.WriteLine("\n<><><><><><><><><><> bancos <><><><><><<><><><><><");
        ContaBancaria conta1 = new ContaCorrente();
        conta1.Depositar(1000);
        conta1.Sacar(200);

        ContaBancaria conta2 = new ContaPoupanca();
        conta2.Depositar(500);
        conta2.Sacar(600);


        Console.WriteLine("\n<><><><><><><><><><> formas <><><><><><<><><><><><");
        Forma quadrado = new Quadrado { Lado = 44 };
        Forma triangulo = new Triangulo { Base = 8, Altura = 30 };
        Console.WriteLine($"Área do quadrado: {quadrado.CalcularArea()}");
        Console.WriteLine($"Área do triângulo: {triangulo.CalcularArea()}");


        Console.WriteLine("\n<><><><><><><><><><> instrumentos <><><><><><<><><><><><");
        InstrumentoMusical guitarra = new Guitarra();
        InstrumentoMusical piano = new Piano();
        guitarra.Tocar();
        piano.Tocar();


        Console.WriteLine("\n<><><><><><><><><><> eletrônicos <><><><><><<><><><><><");
        Eletronico celular = new Smartphone();
        Eletronico notebook = new Notebook();
        celular.Ligar();
        notebook.Ligar();


        Console.WriteLine("\n<><><><><><><><><><> mídias <><><><><><<><><><><><");
        Midia cd = new CD { Titulo = "Melhores hits do planeta Ozonoico" };
        Midia dvd = new DVD { Titulo = "Vídeo cassetadas do Faustão" };
        cd.ExibirDetalhes();
        dvd.ExibirDetalhes();
    }
}
