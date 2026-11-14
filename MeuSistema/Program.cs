namespace MeuSistema;

class Program
{
    static void Main(string[] args)
    {
        int opção = -1;
        while (opção != 0)
        {
            Console.WriteLine("1 - cadastrar usuário");
            Console.WriteLine("2 - listar usuários");
            Console.WriteLine("0 - sair");
            opção = int.Parse(Console.ReadLine());

            switch (opção)
            {
                case 1: usuario.cadastrar(); break;
                case 2: usuario.listar(); break;

            }
        }

        int opção = -1;
        while (opção != 0)
        {
            Console.WriteLine("1-Cadastrar 2-Listar 3-Buscar 4-Remover 5-Entrar 0-Sair");
            try { opção = int.Parse(Console.ReadLine()); }
            catch (FormatException) { opção = -1; }

            switch (opção)
            {
                case 1: usuario.cadastrar(); break;
                case 2: usuario.listar(); break;
                case 3: usuario.Buscar(); break;
                case 4: usuario.Remover(); break;
                case 5: usuario.Entrar(); break;
                case 0: break;
                default: Console.WriteLine("Opção invalida!"); break;

            }
        }

    }
}
