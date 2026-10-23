namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> saudacaoPt = idioma => Console.WriteLine($"[{idioma}] Boas-vindas!");
            Action<string> saudacaoEn = idioma => Console.WriteLine($"[{idioma}] Welcome!");
            Action<string> saudacaoEs = idioma => Console.WriteLine($"[{idioma}] ¡Bienvenido!");

            Console.WriteLine("Escolha um idioma/Choose a Language/Elige un idioma: ");

            while (true)
            {
                Console.WriteLine("\n1 - Português");
                Console.WriteLine("2 - English");
                Console.WriteLine("3 - Español");
                Console.WriteLine("0 - Sair / Exit");
                Console.Write("Opção: ");

                string opcao = Console.ReadLine() ?? "";

                if (opcao == "0") break;

                switch (opcao)
                {
                    case "1":
                        saudacaoPt("Português");
                        break;
                    case "2":
                        saudacaoEn("English");
                        break;
                    case "3":
                        saudacaoEs("Español");
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida/Choose a valid option/Elige una opción válida");
                        break;
                }
            }
        }
    }
}
