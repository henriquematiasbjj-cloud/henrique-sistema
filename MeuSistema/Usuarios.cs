class usuario
{
    public static List<string> nomes = new List<string>();
    public static List<string> logins = new List<string>();
    public static List<string> senhas = new List<string>();

    public static void cadastrar()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Usuario: ");
        string login = Console.ReadLine();
        Console.Write("Senha (minimo 4 caracteres): ");
        string senha = Console.ReadLine();

        if (login == "" || senha.Length < 4)
        {
            Console.WriteLine("Dados invalido!");

        }
        else if (logins.Contains(login))
        {
            Console.WriteLine("Esse usuario ja existe!");

        }
        else
        {
            nomes.Add(nome);
            logins.Add(login);
            senhas.Add(senha);
            Console.WriteLine("Usuario cadastrado!");


        }
    }

    public static void listar()
    {
        
    }
}