namespace exercicio7
{
    internal class Logger
    {
        public void LogToConsole(string mensagem)
        {
            Console.WriteLine($"[Console-Log] Simulação de log no Console: {mensagem}");
        }

        public void LogToFile(string mensagem)
        {
            Console.WriteLine($"Simulação de log no arquivo: {mensagem}");
        }

        public void LogToDatabase(string mensagem)
        {
            Console.WriteLine($"Simulação de log no database: {mensagem}");
        }
    }
}
