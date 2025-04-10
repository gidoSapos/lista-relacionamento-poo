namespace lista00; 
class Program
{
    static void Main(String[] args) 
    { 
       Somatorio obj = new Somatorio();
       Console.WriteLine("Insira o número que deseja somar: ");
       int numero = int.Parse(Console.ReadLine());
       Console.WriteLine(obj.Sum(numero)); 

       LivroNotas notas = new LivroNotas();
       Console.WriteLine($"Sua nota é : {notas.Pontuacao()}");

       Relogio i = new Relogio();
       double resultado = i.Milisegundos();
        if (resultado != -1)
        {
            Console.WriteLine($"Milissegundos pós meia-noite: {resultado}");
        }
        
        Media media = new Media();
        int[] notasDaTurma = { 70, 80, 90, 60 };
        int minhaNota = 85;
        bool a = media.MelhorQueMedia(notasDaTurma, minhaNota);
        Console.WriteLine(a);


    }
}