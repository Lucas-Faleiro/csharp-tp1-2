namespace exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Robustez em Invocação de Delegates ===");
            Logger logger = new Logger();

            // Delegate nullable: pode não ter nenhum método associado
            Action<string>? multiLogger = null;

            string mensagem = "Mensagem de teste para log";

            // Teste 1: nenhum método associado
            Console.WriteLine("\n--- Teste 1: sem nenhum método associado ---");
            multiLogger?.Invoke(mensagem);
            Console.WriteLine("Nenhuma exceção ocorreu.");

            // Teste 2: com métodos associados
            Console.WriteLine("\n--- Teste 2: com métodos associados ---");
            multiLogger += logger.LogToConsole;
            multiLogger += logger.LogToDatabase;
            multiLogger += logger.LogToFile;
            multiLogger?.Invoke(mensagem);

            // Teste 3: após remover todos os métodos
            Console.WriteLine("\n--- Teste 3: após remover todos os métodos ---");
            multiLogger -= logger.LogToConsole;
            multiLogger -= logger.LogToDatabase;
            multiLogger -= logger.LogToFile;
            multiLogger?.Invoke(mensagem);
            Console.WriteLine("Nenhuma exceção ocorreu.");
        }
    }
}
