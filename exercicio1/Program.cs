namespace exercicio1
{
    public delegate decimal CalculateDiscount(decimal preco);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Cálculo de Desconto ===");
            Console.Write("Informe o preço original do produto: R$ ");
            try
            {
                decimal input = decimal.Parse(Console.ReadLine());
                decimal preçoOriginal = Math.Round(input, 2);

                CalculateDiscount calculoDesconto = AplicarDesconto;
                decimal precoFinal = calculoDesconto(preçoOriginal);
                Console.WriteLine($"Preço final é de R${precoFinal:F2}");
            }
            catch (FormatException error)
            {
                Console.WriteLine("Por favor digite no formato correto.");
            }
        }

        static decimal AplicarDesconto(decimal preco)
        {
            return Math.Round(preco * 0.9m, 2);
        }
    }
}
