namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sensor de Temperatura ===");
            var sensor = new TemperatureSensor();

            sensor.TemperaturaUltrapassada += sensor.NotificarTemperatura;

            while (true)
            {

                Console.WriteLine("Digite a temperatura atual do sensor(ou 'sair'):");
                Console.Write("Temperatura: ");
                string temperatura = Console.ReadLine();

                if (temperatura == "sair") break;

                if (double.TryParse(temperatura, out double temp))
                    sensor.alterarTemperatura(temp);
                else
                {
                    Console.WriteLine("Digite um valor válido");
                }
                Console.WriteLine();
            }
        }
    }
}

