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
        if (nomes.Count == 0)
        {
            Console.WriteLine("Nenhum usuario cadastrado. ");
            return;

        }
        for (int i = 0; i < nomes.Count; i++)
        {
            // a senha nunca e mostrada
            Console.WriteLine((i + 1) + ". " + nomes[i] + "(" + logins[i] + ")");

        }
    }

    public static void Buscar()
    {
        Console.Write("Buscar por nome: ");
        string termo = Console.ReadLine().ToLower();

        for (int i = 0; i < nomes.Count; i++)
        {
            if (nomes[i].ToLower().Contains(termo))
            {
                Console.WriteLine(nomes[i] + " (" + logins[i] + ")");

            }
        }
    } 

    public static void Remover()
    {
        Console.Write("Usuario a remover: ");
        string login = Console.ReadLine();
        int i = logins.IndexOf(login);   // -1 se não achar

        if (i == -1)
        {
            Console.WriteLine("Usuario não encontrdao. ");
            return;
        }

        // remover das tres listas, senão os dados se misturam
        nomes.RemoveAt(i);
        logins.RemoveAt(i);
        senhas.RemoveAt(i);
        Console.WriteLine("Usuario removido!");
    }

    public static void Entrar()
    {
        for (int tentativa = 1; tentativa <= 3; tentativa++)
        {
            Console.Write("Usuário: ");
            string login = Console.ReadLine();
            Console.Write("senha: ");
            string senha = Console.ReadLine();

            int i = logins.IndexOf(login);
            if (i != -1 && senhas[i] == senha)
            {
                Console.WriteLine("Bem-vindo(a), " + nomes[i]);
                return;

            }
            Console.WriteLine("Usuário ou senha invalidas. ");
        }
    }

}