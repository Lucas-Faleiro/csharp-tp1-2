namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Cálculo de Área de Retângulo ===");
            try
            {
                Console.Write("Informe a base do retângulo: ");
                double baseInput = double.Parse(Console.ReadLine());
                Console.Write("Informe a altura do retângulo: ");
                double alturaInput = double.Parse(Console.ReadLine());

                Func<double, double, double> calcularArea = CalcularAreaRetangulo;
                double areaDoRetangulo = calcularArea(baseInput, alturaInput);
                Console.WriteLine($"A área do retângulo é de: {areaDoRetangulo}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Formato inserido incorreto, tente digitar números");
            }
        }

        static double CalcularAreaRetangulo(double rtBase, double rtAltura)
        {
            return rtBase * rtAltura;
        }
    }
}
