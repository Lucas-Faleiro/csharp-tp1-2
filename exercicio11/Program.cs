namespace exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Manipulação de Strings com Delegates Encadeados ===");

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine() ?? "";

            Console.Write("Digite o sobrenome: ");
            string sobrenome = Console.ReadLine() ?? "";

            Func<string, string, string> processarNome = ConcatenarNome;

            processarNome += ConverterParaMaiusculas;
            processarNome += RemoverEspacos;

            string resultado = processarNome(nome, sobrenome);
            Console.WriteLine($"Resultado final retornado pelo delegate: {resultado}");
            //Executa todos os métodos adicionados mas só retorna do último
        }

        static string ConcatenarNome(string nome, string sobrenome)
        {
            string resultado = $"{nome} {sobrenome}";
            Console.WriteLine($"Concatenando -> {resultado}");
            return resultado;
        }

        static string ConverterParaMaiusculas(string nome, string sobrenome)
        {
            string resultado = $"{nome} {sobrenome}".ToUpper();
            Console.WriteLine($"Convertendo para Maiusculas -> {resultado}");
            return resultado;
        }

        static string RemoverEspacos(string nome, string sobrenome)
        {
            string resultado = $"{nome}{sobrenome}".Replace(" ", "").ToUpper();
            Console.WriteLine($"Removendo espaços: {resultado}");
            return resultado;
        }
    }
}
