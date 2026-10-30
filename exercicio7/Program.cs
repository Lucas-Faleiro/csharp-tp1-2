namespace exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Robustez em Invocação de Delegates ===");
            Logger logger = new Logger();

            Action<string>? multiLogger = null;

            string mensagem = "Mensagem de teste para log";

            Console.WriteLine("\n--- Teste 1: sem nenhum método associado ---");
            multiLogger?.Invoke(mensagem);
            Console.WriteLine("Nenhuma exceção ocorreu.");

            Console.WriteLine("\n--- Teste 2: com métodos associados ---");
            multiLogger += logger.LogToConsole;
            multiLogger += logger.LogToDatabase;
            multiLogger += logger.LogToFile;
            multiLogger?.Invoke(mensagem);

            Console.WriteLine("\n--- Teste 3: após remover todos os métodos ---");
            multiLogger -= logger.LogToConsole;
            multiLogger -= logger.LogToDatabase;
            multiLogger -= logger.LogToFile;
            multiLogger?.Invoke(mensagem);
            Console.WriteLine("Nenhuma exceção ocorreu.");
        }
    }
}
