namespace lista02;
class CadastroDeUsuarios
{
    private string nome;
    private string senha;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Senha
    {
        get { return senha; }
        set
        {
            if (value.Length >= 8)
            {
                senha = value;
            }
            else
            {
                Console.WriteLine("Senha inválida! A senha deve conter pelo menos 8 caracteres.");
                senha = "senha_padrao";
            }
        }
    }

    public CadastroDeUsuarios(string nome, string senha)
    {
        Nome = nome;
        Senha = senha;
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Usuário: {Nome}");
        Console.WriteLine($"Senha: {(senha == "senha_padrao" ? "[senha inválida]" : senha)}");
    }
}

