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
    }
}
