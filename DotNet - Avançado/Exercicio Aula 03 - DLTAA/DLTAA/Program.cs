namespace DLTAA
{
    class Program
    {
        static void Main(string[] args)
        {

            bool execute = true;
            while (execute)
            {
                Console.WriteLine("\n Escolha uma opção:");
                Console.WriteLine("1 - Async/Await");
                Console.WriteLine("2 - Delegates");
                Console.WriteLine("3 - Linq");
                Console.WriteLine("4 - Threads");
                Console.WriteLine("0 - Sair");

                string? opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Classes.AsyncAwait.Run();
                        break;
                    case "2":
                        Console.WriteLine("\nResultado:");
                        Classes.Delegates.Run();
                        break;
                    case "3":
                        Classes.Linq.Run();
                        break;
                    case "4":
                        Classes.Threads.Run();
                        break;
                    case "0":
                        execute = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            }

        }
    }
}
