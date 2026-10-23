namespace exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Multicast Loggers ===");
            Logger logger = new Logger();
            Action<string> multiLogger = logger.LogToConsole;
            multiLogger += logger.LogToDatabase;
            multiLogger += logger.LogToFile;

            string mensagem = "Mensagem de teste para log";

            multiLogger(mensagem);
        }
    }
}
